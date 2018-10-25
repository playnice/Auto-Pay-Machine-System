using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Car_Parking_System
{
   
    public partial class CarParkingSystem : Form
    {
        public static List<Panel> listPanel = new List<Panel>();
        public CarParkingSystem()
        {
            InitializeComponent();

        }
        public class Ticket
        {
            private int ID = 0;
            private DateTime enterTimestamp;
            private DateTime paymentTimestamp;
            private bool payStatus;
            private int hrs;
            private int mins;
            public TicketMachine TM = new TicketMachine();

            public Ticket()
            {
                this.enterTimestamp = System.DateTime.Now; 
                this.payStatus = false;
            }
            public int getID() { return this.ID; }
            public void setID(int ID) { this.ID = ID; }
            public DateTime getEnterTimestamp() { return this.enterTimestamp; }
            //public void setEnterTimestamp(DateTime timestamp) { this.enterTimestamp = timestamp; }
            public DateTime getPaymentTimestamp() { return this.paymentTimestamp; }
            public void setPaymentTimestamp(DateTime timestamp) { this.paymentTimestamp = timestamp; }
            public bool getPayStatus() { return this.payStatus; }
            public void setPayStatus(bool payStatus) { this.payStatus = payStatus; }
            public int getHrs() { return this.hrs; }
            public void setHrs(int hr) { this.hrs = hr; }
            public int getMins() { return this.mins; }
            public void setMins(int min) { this.mins = min; }

        }
        
        public class Driver
        {
            private Ticket ticket;

            public void takeTicket(Ticket t) { this.ticket = t; }
            public Ticket getDriverTicket() { return this.ticket; }
        }

        public class PayMachine
        {
            private double rate = 2;
            private double revenue = 0;
            private string username = "admin";
            private string password = "123";
            private double feesPaid = 0;
            private double fees;
            
            public PayMachine() { }
            public void calculateTime(Ticket ticket)
            {
                DateTime enter = ticket.getEnterTimestamp();
                DateTime payment = ticket.getPaymentTimestamp();
                //Testing...
                //DateTime ent = new DateTime(2010, 05, 12, 13, 15, 00);
                //DateTime pay = new DateTime(2010, 05, 12, 15, 36, 00);
                //double totalTime = (pay.Subtract(ent).TotalMinutes);

                double totalTime = (payment.Subtract(enter).TotalMinutes);
                int intTotalTime = (int)totalTime;
                ticket.setHrs(intTotalTime / 60);
                ticket.setMins(intTotalTime % 60);
            }
            public double calculateFees(double hrsParked) { return (rate * hrsParked); }
            public double getRate() { return this.rate; }
            public void setRate(double rate) { this.rate = rate; }
            public double getRevenue() { return this.revenue; }
            public void setRevenue(double rev) { this.revenue = rev; }
            public double change() { return feesPaid - fees; }
            public double getFees() { return this.fees; }
            public void setFees(double fees) { this.fees = fees; }
            public string getUsername() { return this.username; }
            public string getPassword() { return this.password; }
            public double getFeesPaid() { return this.feesPaid; }
            public double payRM1() { return this.feesPaid++; }
            public double payRM5() { return this.feesPaid += 5; }
            public double payRM10() { return this.feesPaid += 10; }
            public bool checkLogin(string id,string pw)
            {
                if(this.username == id &&  this.password == pw)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public class Admin
        {
            PayMachine adminLogin = new PayMachine();
            public bool login(string id, string pw)
            {
                if (adminLogin.checkLogin(id,pw) == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public class TechnicalSupport
        {
            public void techSupport()
            {
                MessageBox.Show("Transmission success, please speak to our staff now.");
            }
        }

        public class TicketMachine
        {
            private uint remainingTicket = 100;
            private uint remainingSpace = 80;

            public void gateOpened() { MessageBox.Show("Gate opened."); }
            public uint getRemainSpace() { return this.remainingSpace; }
            public uint getRemainTicket() { return this.remainingTicket; }
            public bool readTicket(Ticket ticket)
            {
                if (ticket.getPayStatus() == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            public bool dispenseTicket()
            {
                if (remainingTicket == 0)
                {
                    MessageBox.Show("Sorry, no ticket left. Please ask for staff's assistance.");
                    return false;
                }
                else if (remainingSpace == 0)
                {
                    MessageBox.Show("Sorry, no space left. Please ask for staff's assistance.");
                    return false;
                }
                remainingTicket--;
                remainingSpace--;
                return true;
            }
        }


        Driver driver = new Driver();
        TechnicalSupport techSupp = new TechnicalSupport();
        PayMachine PM = new PayMachine();
        TicketMachine TM = new TicketMachine();
        double driverMins;
        double driverHrs;

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=
                C:\Users\User\Desktop\SE\Car Parking System\Car Parking System\ParkingDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void CarParkingSystem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingDatabaseDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.parkingDatabaseDataSet.Ticket);
            // TODO: This line of code loads data into the 'parkingDatabaseDataSet.Ticket' table. You can move, or remove it, as needed.
            this.ticketTableAdapter.Fill(this.parkingDatabaseDataSet.Ticket);



            listPanel.Add(entrancePanel);
            listPanel.Add(payMachinePanel);
            listPanel.Add(exitPanel);
            listPanel.Add(AdminLoginPanel);
            listPanel.Add(AdminPanel);
            listPanel.Add(choicePanel);
            
            listPanel[0].BringToFront();

            btnRM1.Enabled = false;
            btnRM5.Enabled = false;
            btnRM10.Enabled = false;
            payMachineDisplay.Multiline = true;
            loginLbl.Visible = false;
            exitBtn.Enabled = false;
            StreamReader sr = new StreamReader("../../Rate.txt");
            string stringRate = sr.ReadLine();
            double convertRate = Convert.ToDouble(stringRate);
            sr.Close();
            PM.setRate(convertRate);
            StreamReader rr = new StreamReader("../../Revenue.txt");
            stringRate = rr.ReadLine();
            double convertRevenue = Convert.ToDouble(stringRate);
            sr.Close();
            PM.setRevenue(convertRevenue);
        }
    

       

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void entranceDisplay_TextChanged(object sender, EventArgs e)
        {
            entranceDisplay.SelectionLength = 0;
        }

        public void entranceTakeTicketBtn_Click(object sender, EventArgs e)
        {
            if(TM.dispenseTicket() == true)
            {
                listPanel[5].BringToFront();
                driver.takeTicket(new Ticket());
                connection.Open();
                using (SqlCommand mycom = new SqlCommand("SELECT COUNT(ID) FROM Ticket", connection))
                {
                    driver.getDriverTicket().setID((int)mycom.ExecuteScalar());
                }
                
                DateTime ent = new DateTime(2010, 05, 12, 13, 15, 00);
                //DateTime pay = new DateTime(2010, 05, 12, 15, 36, 00);
                //driver.getDriverTicket().setEnterTimestamp(ent);
                //driver.getDriverTicket().setPaymentTimestamp(pay);
                using (SqlCommand com = new SqlCommand("INSERT INTO Ticket (ID,enterTimestamp,exitTimestamp,payStatus) Values(@ID,@enter,@exit,@paystat)", connection))
                {
                    com.Parameters.AddWithValue("@ID", driver.getDriverTicket().getID());
                    com.Parameters.AddWithValue("@enter", driver.getDriverTicket().getEnterTimestamp());
                    com.Parameters.AddWithValue("@exit", DBNull.Value);
                    com.Parameters.AddWithValue("@paystat", false);



                    com.ExecuteNonQuery();
                }
                connection.Close();
                
            }
        }

        private void entranceHelpBtn_Click(object sender, EventArgs e)
        {
            techSupp.techSupport();
        }

        private void payMachineHelpBtn_Click(object sender, EventArgs e)
        {
            techSupp.techSupport();
        }

        private void exitHelpBtn_Click(object sender, EventArgs e)
        {
            techSupp.techSupport();
        }

        private void adminLoginHelpBtn_Click(object sender, EventArgs e)
        {
            techSupp.techSupport();
        }

        private void payMachineExitGateBtn_Click(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void exitPayMachineBtn_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void payMachineAdminBtn_Click(object sender, EventArgs e)
        {
            IDTxt.Text = "";
            PWTxt.Text = "";
            listPanel[3].BringToFront();
        }

        private void adminCancelBtn_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void adminLoginBtn_Click(object sender, EventArgs e)
        {
            string id, pw;
            id = IDTxt.Text;
            pw = PWTxt.Text;
            Admin admin = new Admin();
            if (admin.login(id, pw) == true)
            {
                loginLbl.Visible = false;
                adminRevenueTxt.Text = "RM" + string.Format("{0:0.00}", PM.getRevenue());
                adminRateTxt.Text = "RM" + string.Format("{0:0.00}", PM.getRate());
                listPanel[4].BringToFront();
            }
            else
            {
                IDTxt.Text = "";
                PWTxt.Text = "";
                loginLbl.Visible = true;
            }
           
            
        }

        private void adminPageCancelBtn_Click(object sender, EventArgs e)
        {
            adminChgRateTxt.Text = " ";
            listPanel[1].BringToFront();
        }

        private void adminPageOKBtn_Click(object sender, EventArgs e)
        {
            if(adminChgRateTxt.Text == "")
            {
                listPanel[1].BringToFront();
            }
            else
            { 
                double newRate = double.Parse(adminChgRateTxt.Text);
                PM.setRate(newRate);
                MessageBox.Show("Parking rate changed to RM" + newRate + "/hr!");
                listPanel[1].BringToFront();
                FileStream fs = new FileStream("../../Rate.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                StreamWriter sw = new StreamWriter("../../Rate.txt");
                
                sw.Write(newRate);
                sw.Close();
            }
           
           
        }

        private void adminRevenueTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void entrancePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void payMachineInsertTicketBtn_Click(object sender, EventArgs e)
        {
            payMachineInsertTicketBtn.Enabled = false;
            btnRM1.Enabled = true;
            btnRM5.Enabled = true;
            btnRM10.Enabled = true;
            driver.getDriverTicket().setPaymentTimestamp(System.DateTime.Now);
            connection.Open();
            //DateTime pay = new DateTime(2010, 05, 12, 15, 36, 00);
            //driver.getDriverTicket().setPaymentTimestamp(pay);
            using (SqlCommand com = new SqlCommand("UPDATE Ticket SET exitTimestamp = @exitTime WHERE ID = @currentID", connection))
            {
                com.Parameters.AddWithValue("@currentID", driver.getDriverTicket().getID());
                com.Parameters.AddWithValue("@exitTime", driver.getDriverTicket().getPaymentTimestamp());

                com.ExecuteNonQuery();
            }
            connection.Close();
            /*
            DateTime enter = driver.getDriverTicket().getEnterTimestamp();
            DateTime payment = driver.getDriverTicket().getPaymentTimestamp();
            //Testing calculation is functioning or not.
           
            DateTime ent = new DateTime(2010, 05, 12, 13, 15, 00);
            DateTime pay = new DateTime(2010, 05, 12, 15, 36, 00);
            double totalTime = (pay.Subtract(ent).TotalMinutes);

           // double totalTime = (payment.Subtract(enter).TotalMinutes);
            int intTotalTime = (int)totalTime;
            driver.getDriverTicket().setHrs(intTotalTime / 60);
            driver.getDriverTicket().setMins(intTotalTime % 60);
            */
            PM.calculateTime(driver.getDriverTicket());
            driverHrs = driver.getDriverTicket().getHrs();
            driverMins = driver.getDriverTicket().getMins();
            double hrsParked = driverHrs;//Cannot straight away pass argument as driverHrs is int.
            double totalFees = PM.calculateFees(hrsParked);
            PM.setFees(totalFees);
            if (driverHrs == 0)
            {
                if(driverMins <= 15)
                {
                    payMachineDisplay.Text = "Thank you, your payment is free. Please take your ticket.";
                    driver.getDriverTicket().setPayStatus(true);
                    btnRM1.Enabled = false;
                    btnRM5.Enabled = false;
                    btnRM10.Enabled = false;
                }
                else
                {
                    payMachineDisplay.Text = "You have parked for 0 Hours " + driverMins + 
                        " Minutes. Please pay RM" + PM.getRate() + "\r\n\r\n Payment: RM" + PM.getFeesPaid();

                }
            }
            else
            {
                payMachineDisplay.Text = "You have parked for " + driverHrs + " Hours " + driverMins +
                    " Minutes. Please pay RM" + PM.getFees() + "\r\n\r\n Payment: RM" + PM.getFeesPaid();
            }
        }

        private void goPayMachineBtn_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();
        }

        private void goExitGateBtn_Click(object sender, EventArgs e)
        {
            listPanel[2].BringToFront();
        }

        private void btnRM1_Click(object sender, EventArgs e)
        {
            PM.payRM1();
            if (PM.getFeesPaid() >= PM.getFees())
            {
                payMachineDisplay.Text = "Thank you, please take your ticket & RM" + PM.change() + " change. Have a good day.";
                driver.getDriverTicket().setPayStatus(true);
                btnRM1.Enabled = false;
                btnRM5.Enabled = false;
                btnRM10.Enabled = false;
                connection.Open();
                using (SqlCommand com = new SqlCommand("UPDATE Ticket SET payStatus = @payStat WHERE ID = @currentID", connection))
                {
                    com.Parameters.AddWithValue("@currentID", driver.getDriverTicket().getID());
                    com.Parameters.AddWithValue("@payStat", true);

                    com.ExecuteNonQuery();
                }
                connection.Close();
            }
            else
            {
                payMachineDisplay.Text = "You have parked for " + driverHrs + " Hours " + driverMins +
                " Minutes. Please pay RM" + PM.getFees() + "\r\n\r\n Payment: RM" + PM.getFeesPaid();
            }
        }

        private void btnRM5_Click(object sender, EventArgs e)
        {
            PM.payRM5();
            if (PM.getFeesPaid() >= PM.getFees())
            {
                payMachineDisplay.Text = "Thank you, please take your ticket & RM" + PM.change() + " change. Have a good day.";
                driver.getDriverTicket().setPayStatus(true);
                btnRM1.Enabled = false;
                btnRM5.Enabled = false;
                btnRM10.Enabled = false;
                connection.Open();
                using (SqlCommand com = new SqlCommand("UPDATE Ticket SET payStatus = @payStat WHERE ID = @currentID", connection))
                {
                    com.Parameters.AddWithValue("@currentID", driver.getDriverTicket().getID());
                    com.Parameters.AddWithValue("@payStat", true);

                    com.ExecuteNonQuery();
                }
                connection.Close();
            }
            else
            {
                payMachineDisplay.Text = "You have parked for " + driverHrs + " Hours " + driverMins +
                " Minutes. Please pay RM" + PM.getFees() + "\r\n\r\n Payment: RM" + PM.getFeesPaid();
            }
        }

        private void btnRM10_Click(object sender, EventArgs e)
        {
            PM.payRM10();
            if (PM.getFeesPaid() >= PM.getFees())
            {
                payMachineDisplay.Text = "Thank you, please take your ticket & RM" + PM.change() + " change. Have a good day.";
                driver.getDriverTicket().setPayStatus(true);
                btnRM1.Enabled = false;
                btnRM5.Enabled = false;
                btnRM10.Enabled = false;
                connection.Open();
                using (SqlCommand com = new SqlCommand("UPDATE Ticket SET payStatus = @payStat WHERE  = @currentID", connection))
                {
                    com.Parameters.AddWithValue("@currentID", driver.getDriverTicket().getID());
                    com.Parameters.AddWithValue("@payStat", true);

                    com.ExecuteNonQuery();
                }
                connection.Close();
            }
            else
            {
                payMachineDisplay.Text = "You have parked for " + driverHrs + " Hours " + driverMins +
                " Minutes. Please pay RM" + PM.getFees() + "\r\n\r\n Payment: RM" + PM.getFeesPaid();
            }
        }

        private void exitInsertTicketBtn_Click(object sender, EventArgs e)
        {
            if (TM.readTicket(driver.getDriverTicket()) == true)
            { 
                exitDisplay.Text = "Thank You.";
                exitPayMachineBtn.Enabled = false;
                exitHelpBtn.Enabled = false;
                exitBtn.Enabled = true;
                FileStream fs = new FileStream("../../Revenue.txt", FileMode.OpenOrCreate, FileAccess.Write);
                fs.Close();
                StreamWriter sw = new StreamWriter("../../Revenue.txt");

                sw.Write(PM.getRevenue());
                sw.Close();
                TM.gateOpened();
            }
            else
            {
                exitDisplay.Text = "Ticket not paid. Please pay and at pay machine.";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            

        }

        private void tableBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
          

        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkingDatabaseDataSet);

        }

        private void ticketBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.parkingDatabaseDataSet);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
