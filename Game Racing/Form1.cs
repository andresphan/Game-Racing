namespace Game_Racing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x_computer, y_computer, x_player, y_player;
        int diem;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(777, 800);
            xePlayer.Size = new Size(75, 150);
            xePlayer.Location = new Point(300, 400);
            xeComputer.Location = new Point(150, 200);
            timer.Interval =20;
            bom.Size = new Size(152, 149);
            bom.Visible = false;
            diem = 0;

        }
        bool check = false;
        Point td;
       
        private void xePlayer_MouseDown(object sender, MouseEventArgs e)
        {
            check = true;
            td = e.Location;
        }
        int dem = 0;
        private void btn_Click(object sender, EventArgs e)
        {
            dem++;
            if(dem%2!=0)
            {
                timer.Start();
            }
            else
            {
                timer.Start();
            }

        }

        private void xePlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if(check==true)
            {
                PictureBox a = (PictureBox)sender;
                Point tdbd = a.Location;
                tdbd.X += e.Location.X - td.X;
                tdbd.Y += e.Location.Y - td.Y;
                xePlayer.Location = tdbd;

            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            y_computer += 10;
            xeComputer.Location=new Point(x_computer, y_computer);  
            if(y_computer>=this.Height)
            {
                y_computer = 0;
                Random r = new Random();
                x_computer = r.Next(0, this.Width - xeComputer.Width);
                diem++;
                lbl.Text = "Score: " + diem.ToString();
            }
            if(xeComputer.Location.Y +xeComputer.Height >= xePlayer.Location.Y)
            {
               if(xePlayer.Location.X<=xeComputer.Location.X+xePlayer.Width&&xePlayer.Location.X>=xeComputer.Location.X-xePlayer.Width)
                {
                    timer.Stop();
                    xePlayer.Visible = false;
                    xeComputer.Visible = false;
                    bom.Location=new Point(xePlayer.Location.X,xePlayer.Location.Y);
                    bom.Visible = true;
                    DialogResult luachon = MessageBox.Show("DO YOU WANT TO CONTINUE", "NOTIFICATION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(luachon==DialogResult.Yes)
                    {
                        check = false;
                        bom.Visible = false;
                        Random r= new Random();
                        x_computer=r.Next(0, this.Width - xeComputer.Width);
                        y_computer = 0;
                        xeComputer.Visible = true;
                        xePlayer.Visible = true;
                        diem = 0;
                        lbl.Text = "Score: ";
                    }
                    else
                    {
                        this.Close();
                    }
                    
                }               

                

            }
            if(diem==3)
            {
                timer.Interval = 10;
            }else if(diem==7)
            {
                timer.Interval = 3;
            }else if(diem==9)
            {
                timer.Interval= 1;
            }

        }

        private void xePlayer_MouseUp(object sender, MouseEventArgs e)
        {
            check = false;
        }
    }
}