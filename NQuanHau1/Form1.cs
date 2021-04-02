using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NQuanHau1
{
    public partial class Form1 : Form
    {
        int n = 8;
        int so_loi_giai = 0;
        int[] cot = new int[100];
        bool done = false;
        int[,] result = new int[100, 100];
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadChessImage();
        }

        private void loadChessImage()
        {
            var list_controls = GetAll(this, typeof(PictureBox));
            int i = 1, j = 1;
            foreach(var item in list_controls)
            {
               if(j%2 != 0)
                {
                    if (i % 2 != 0)
                    {
                        item.BackgroundImage = Properties.Resources.White_C_3;
                    }
                    else
                    {
                        item.BackgroundImage = Properties.Resources.Black_C_3;
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        item.BackgroundImage = Properties.Resources.Black_C_3;
                    }
                    else
                    {
                        item.BackgroundImage = Properties.Resources.White_C_3;
                    }
                }
                if (i % 8 == 0) j++;
                i++;
            }
        }

        private void showLabel()
        {
            lbX2.Visible = true;
            lbY2.Visible = true;
            lbX3.Visible = true;
            lbY3.Visible = true;
            lbX4.Visible = true;
            lbY4.Visible = true;
            lbX5.Visible = true;
            lbY5.Visible = true;
            lbX6.Visible = true;
            lbY6.Visible = true;
            lbX7.Visible = true;
            lbY7.Visible = true;
            lbX8.Visible = true;
            lbY8.Visible = true;
        }

        private void showAllPictureBox()
        {
            fpnlChess.Size = new Size(538, 538);

            pB11.Visible = true;
            pB12.Visible = true;
            pB13.Visible = true;
            pB14.Visible = true;
            pB15.Visible = true;
            pB16.Visible = true;
            pB17.Visible = true;
            pB18.Visible = true;
            pB21.Visible = true;
            pB22.Visible = true;
            pB23.Visible = true;
            pB24.Visible = true;
            pB25.Visible = true;
            pB26.Visible = true;
            pB27.Visible = true;
            pB28.Visible = true;
            pB31.Visible = true;
            pB32.Visible = true;
            pB33.Visible = true;
            pB34.Visible = true;
            pB35.Visible = true;
            pB36.Visible = true;
            pB37.Visible = true;
            pB38.Visible = true;
            pB41.Visible = true;
            pB42.Visible = true;
            pB43.Visible = true;
            pB44.Visible = true;
            pB45.Visible = true;
            pB46.Visible = true;
            pB47.Visible = true;
            pB48.Visible = true;
            pB51.Visible = true;
            pB52.Visible = true;
            pB53.Visible = true;
            pB54.Visible = true;
            pB55.Visible = true;
            pB56.Visible = true;
            pB57.Visible = true;
            pB58.Visible = true;
            pB61.Visible = true;
            pB62.Visible = true;
            pB63.Visible = true;
            pB64.Visible = true;
            pB65.Visible = true;
            pB66.Visible = true;
            pB67.Visible = true;
            pB68.Visible = true;
            pB71.Visible = true;
            pB72.Visible = true;
            pB73.Visible = true;
            pB74.Visible = true;
            pB75.Visible = true;
            pB76.Visible = true;
            pB77.Visible = true;
            pB78.Visible = true;
            pB81.Visible = true;
            pB82.Visible = true;
            pB83.Visible = true;
            pB84.Visible = true;
            pB85.Visible = true;
            pB86.Visible = true;
            pB87.Visible = true;
            pB88.Visible = true;
        }
        private void showPictureBox()
        {
            var list_controls = GetAll(this, typeof(PictureBox));
            foreach (var item in list_controls)
            {
                item.Visible = true;
            }
        }

        private void hiddenLabel()
        {
            for (int i = 8; i > n; i--)
            {
                if (i == 2)
                {
                    lbX2.Visible = false;
                    lbY2.Visible = false;
                }
                if (i == 3)
                {
                    lbX3.Visible = false;
                    lbY3.Visible = false;
                }
                else if (i == 4)
                {
                    lbX4.Visible = false;
                    lbY4.Visible = false;
                }
                else if (i == 5)
                {
                    lbX5.Visible = false;
                    lbY5.Visible = false;
                }
                else if (i == 6)
                {
                    lbX6.Visible = false;
                    lbY6.Visible = false;
                }
                else if (i == 7)
                {
                    lbX7.Visible = false;
                    lbY7.Visible = false;
                }
                else if (i == 8)
                {
                    lbX8.Visible = false;
                    lbY8.Visible = false;
                }
            }
        }

        private void hiddenBox()
        {
            //ẩn hàng ngang
            for (int i = 8; i > n; i--)
            {
                for (int j = 8; j >= 1; j--)
                {
                    if (i == 1)
                    {
                        if (j == 1)
                        {
                            pB11.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB12.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB13.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB14.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB15.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB16.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB17.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB18.Visible = false;
                        }
                    }
                    else if (i == 2)
                    {
                        if (j == 1)
                        {
                            pB21.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB22.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB23.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB24.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB25.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB26.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB27.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB28.Visible = false;
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 1)
                        {
                            pB31.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB32.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB33.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB34.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB35.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB36.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB37.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB38.Visible = false;
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 1)
                        {
                            pB41.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB42.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB43.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB44.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB45.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB46.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB47.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB48.Visible = false;
                        }
                    }
                    else if (i == 5)
                    {
                        if (j == 1)
                        {
                            pB51.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB52.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB53.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB54.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB55.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB56.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB57.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB58.Visible = false;
                        }
                    }
                    else if (i == 6)
                    {
                        if (j == 1)
                        {
                            pB61.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB62.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB63.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB64.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB65.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB66.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB67.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB68.Visible = false;
                        }
                    }
                    else if (i == 7)
                    {
                        if (j == 1)
                        {
                            pB71.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB72.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB73.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB74.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB75.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB76.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB77.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB78.Visible = false;
                        }
                    }
                    else if (i == 8)
                    {
                        if (j == 1)
                        {
                            pB81.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB82.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB83.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB84.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB85.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB86.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB87.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB88.Visible = false;
                        }
                    }
                }
            }

            //ẩn hàng dọc
            for (int i = 8; i >= 1; i--)
            {
                for (int j = 8; j > n; j--)
                {
                    if (i == 1)
                    {
                        if (j == 1)
                        {
                            pB11.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB12.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB13.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB14.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB15.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB16.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB17.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB18.Visible = false;
                        }
                    }
                    else if (i == 2)
                    {
                        if (j == 1)
                        {
                            pB21.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB22.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB23.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB24.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB25.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB26.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB27.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB28.Visible = false;
                        }
                    }
                    else if (i == 3)
                    {
                        if (j == 1)
                        {
                            pB31.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB32.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB33.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB34.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB35.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB36.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB37.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB38.Visible = false;
                        }
                    }
                    else if (i == 4)
                    {
                        if (j == 1)
                        {
                            pB41.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB42.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB43.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB44.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB45.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB46.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB47.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB48.Visible = false;
                        }
                    }
                    else if (i == 5)
                    {
                        if (j == 1)
                        {
                            pB51.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB52.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB53.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB54.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB55.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB56.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB57.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB58.Visible = false;
                        }
                    }
                    else if (i == 6)
                    {
                        if (j == 1)
                        {
                            pB61.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB62.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB63.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB64.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB65.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB66.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB67.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB68.Visible = false;
                        }
                    }
                    else if (i == 7)
                    {
                        if (j == 1)
                        {
                            pB71.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB72.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB73.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB74.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB75.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB76.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB77.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB78.Visible = false;
                        }
                    }
                    else if (i == 8)
                    {
                        if (j == 1)
                        {
                            pB81.Visible = false;
                        }
                        else if (j == 2)
                        {
                            pB82.Visible = false;
                        }
                        else if (j == 3)
                        {
                            pB83.Visible = false;
                        }
                        else if (j == 4)
                        {
                            pB84.Visible = false;
                        }
                        else if (j == 5)
                        {
                            pB85.Visible = false;
                        }
                        else if (j == 6)
                        {
                            pB86.Visible = false;
                        }
                        else if (j == 7)
                        {
                            pB87.Visible = false;
                        }
                        else if (j == 8)
                        {
                            pB88.Visible = false;
                        }
                    }
                }
            }
        }

        private void changeFlowPanelSize()
        {
            if (n >= 8)
            {
                fpnlChess.Size = new Size(538, 538);
                return;
            }
            else if (n <= 3)
            {
                fpnlChess.Size = new Size((538 * n / 8) + n, (538 * n / 8) + n);
                return;
            }

            fpnlChess.Size = new Size((538 * n / 8) + 1, (538 * n / 8) + 1);
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        private void btnInputNQueen_Click(object sender, EventArgs e)
        {
            n = (int)numberNQueen.Value;

            if (n <= 8)
            {
                showLabel();
                showPictureBox();
                changeFlowPanelSize();
                hiddenBox();
                hiddenLabel();
            }


            btnInputNQueen.Enabled = false;
            numberNQueen.Enabled = false;

            btnStart.Enabled = true;
            btnResetSetting.Enabled = true;
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            lbSpeed.Text = "Tốc độ: " + trackBarSpeed.Value;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(() =>
            {
                btnDone.Enabled = true;
                removeAllQueen();
                rtxtAnswer.Text = "";
                so_loi_giai = 0;

                xepHau(1);
                MessageBox.Show("Đã tìm được tất cả " + so_loi_giai.ToString() + " lời giải");
                rtxtAnswer.Enabled = true;
                btnDone.Enabled = false;
            }));

            t.IsBackground = true;

            t.Start();

            btnStart.Enabled = false;
            btnDone.Enabled = true;
        }

        private bool Ok(int x, int y)
        {
            //kiểm tra cách đặt có thỏa mãn không
            for (int i = 1; i < x; i++)
                if (cot[i] == y || Math.Abs(i - x) == Math.Abs(cot[i] - y))
                    return false;
            //Nếu kiểm tra hết các trường hợp vẫn không sai thì trả về true
            return true;
        }

        private void Xuat()
        {
            so_loi_giai++;

            for (int i = 1; i <= n; i++)
            {
                result[so_loi_giai-1, i-1] = cot[i];
                rtxtAnswer.Text = rtxtAnswer.Text + "[" + i.ToString() + ", " + cot[i].ToString() + "] ";
            }
                
            rtxtAnswer.Text = rtxtAnswer.Text + "\n";

            grBAnswer.Text = "Số lời giải: " + so_loi_giai.ToString();
        }
        private void xepHau(int i)
        {
            for (int j = 1; j <= n; j++)
            {
                if (!done)
                {
                    removeQueen(i, j - 1);
                    setQueen(i, j);
                    Thread.Sleep(1000 / trackBarSpeed.Value);
                }

                // thử đặt quân hậu vào các cột từ 1 đến n
                if (Ok(i, j))
                {
                    //nếu cách đặt này thỏa mãn thì lưu lại vị trí
                    cot[i] = j;
                    //nếu đặt xong quân hậu thứ n thì xuất ra một kết quả
                    if (i == n)
                    {
                        Xuat();
                        if (!done)
                        {
                            removeQueen(i, j);
                        }
                    }
                    else xepHau(i + 1);
                }
                else
                {
                    if (!done)
                    {
                        removeQueen(i, j);
                    }
                }

                if (j == n)
                {
                    if (!done)
                    {
                        removeQueen(i, j);
                    }
                }
            }
        }

        private void setQueen(int i, int j)
        {
            if (i == 1)
            {
                if (j == 1)
                {
                    pB11.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB12.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB13.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB14.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB15.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB16.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB17.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB18.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 2)
            {
                if (j == 1)
                {
                    pB21.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB22.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB23.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB24.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB25.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB26.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB27.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB28.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 3)
            {
                if (j == 1)
                {
                    pB31.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB32.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB33.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB34.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB35.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB36.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB37.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB38.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 4)
            {
                if (j == 1)
                {
                    pB41.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB42.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB43.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB44.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB45.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB46.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB47.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB48.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 5)
            {
                if (j == 1)
                {
                    pB51.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB52.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB53.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB54.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB55.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB56.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB57.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB58.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 6)
            {
                if (j == 1)
                {
                    pB61.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB62.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB63.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB64.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB65.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB66.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB67.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB68.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 7)
            {
                if (j == 1)
                {
                    pB71.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB72.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB73.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB74.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB75.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB76.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB77.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB78.Image = Properties.Resources.White_Q_5;
                }
            }
            else if (i == 8)
            {
                if (j == 1)
                {
                    pB81.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 2)
                {
                    pB82.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 3)
                {
                    pB83.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 4)
                {
                    pB84.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 5)
                {
                    pB85.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 6)
                {
                    pB86.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 7)
                {
                    pB87.Image = Properties.Resources.White_Q_5;
                }
                else if (j == 8)
                {
                    pB88.Image = Properties.Resources.White_Q_5;
                }
            }
        }

        private void removeQueen(int i, int j)
        {
            if (i == 1)
            {
                if (j == 1)
                {
                    pB11.Image = null;
                }
                else if (j == 2)
                {
                    pB12.Image = null;
                }
                else if (j == 3)
                {
                    pB13.Image = null;
                }
                else if (j == 4)
                {
                    pB14.Image = null;
                }
                else if (j == 5)
                {
                    pB15.Image = null;
                }
                else if (j == 6)
                {
                    pB16.Image = null;
                }
                else if (j == 7)
                {
                    pB17.Image = null;
                }
                else if (j == 8)
                {
                    pB18.Image = null;
                }
            }
            else if (i == 2)
            {
                if (j == 1)
                {
                    pB21.Image = null;
                }
                else if (j == 2)
                {
                    pB22.Image = null;
                }
                else if (j == 3)
                {
                    pB23.Image = null;
                }
                else if (j == 4)
                {
                    pB24.Image = null;
                }
                else if (j == 5)
                {
                    pB25.Image = null;
                }
                else if (j == 6)
                {
                    pB26.Image = null;
                }
                else if (j == 7)
                {
                    pB27.Image = null;
                }
                else if (j == 8)
                {
                    pB28.Image = null;
                }
            }
            else if (i == 3)
            {
                if (j == 1)
                {
                    pB31.Image = null;
                }
                else if (j == 2)
                {
                    pB32.Image = null;
                }
                else if (j == 3)
                {
                    pB33.Image = null;
                }
                else if (j == 4)
                {
                    pB34.Image = null;
                }
                else if (j == 5)
                {
                    pB35.Image = null;
                }
                else if (j == 6)
                {
                    pB36.Image = null;
                }
                else if (j == 7)
                {
                    pB37.Image = null;
                }
                else if (j == 8)
                {
                    pB38.Image = null;
                }
            }
            else if (i == 4)
            {
                if (j == 1)
                {
                    pB41.Image = null;
                }
                else if (j == 2)
                {
                    pB42.Image = null;
                }
                else if (j == 3)
                {
                    pB43.Image = null;
                }
                else if (j == 4)
                {
                    pB44.Image = null;
                }
                else if (j == 5)
                {
                    pB45.Image = null;
                }
                else if (j == 6)
                {
                    pB46.Image = null;
                }
                else if (j == 7)
                {
                    pB47.Image = null;
                }
                else if (j == 8)
                {
                    pB48.Image = null;
                }
            }
            else if (i == 5)
            {
                if (j == 1)
                {
                    pB51.Image = null;
                }
                else if (j == 2)
                {
                    pB52.Image = null;
                }
                else if (j == 3)
                {
                    pB53.Image = null;
                }
                else if (j == 4)
                {
                    pB54.Image = null;
                }
                else if (j == 5)
                {
                    pB55.Image = null;
                }
                else if (j == 6)
                {
                    pB56.Image = null;
                }
                else if (j == 7)
                {
                    pB57.Image = null;
                }
                else if (j == 8)
                {
                    pB58.Image = null;
                }
            }
            else if (i == 6)
            {
                if (j == 1)
                {
                    pB61.Image = null;
                }
                else if (j == 2)
                {
                    pB62.Image = null;
                }
                else if (j == 3)
                {
                    pB63.Image = null;
                }
                else if (j == 4)
                {
                    pB64.Image = null;
                }
                else if (j == 5)
                {
                    pB65.Image = null;
                }
                else if (j == 6)
                {
                    pB66.Image = null;
                }
                else if (j == 7)
                {
                    pB67.Image = null;
                }
                else if (j == 8)
                {
                    pB68.Image = null;
                }
            }
            else if (i == 7)
            {
                if (j == 1)
                {
                    pB71.Image = null;
                }
                else if (j == 2)
                {
                    pB72.Image = null;
                }
                else if (j == 3)
                {
                    pB73.Image = null;
                }
                else if (j == 4)
                {
                    pB74.Image = null;
                }
                else if (j == 5)
                {
                    pB75.Image = null;
                }
                else if (j == 6)
                {
                    pB76.Image = null;
                }
                else if (j == 7)
                {
                    pB77.Image = null;
                }
                else if (j == 8)
                {
                    pB78.Image = null;
                }
            }
            else if (i == 8)
            {
                if (j == 1)
                {
                    pB81.Image = null;
                }
                else if (j == 2)
                {
                    pB82.Image = null;
                }
                else if (j == 3)
                {
                    pB83.Image = null;
                }
                else if (j == 4)
                {
                    pB84.Image = null;
                }
                else if (j == 5)
                {
                    pB85.Image = null;
                }
                else if (j == 6)
                {
                    pB86.Image = null;
                }
                else if (j == 7)
                {
                    pB87.Image = null;
                }
                else if (j == 8)
                {
                    pB88.Image = null;
                }
            }
        }

        private void removeAllQueen()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    removeQueen(i, j);
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnResetSetting_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void btndone_Click(object sender, EventArgs e)
        {
            done = true;
            btnDone.Enabled = false;
            btnStart.Enabled = false;
        }

        private void showValue(object sender, MouseEventArgs e)
        {
            Thread t = new Thread(() =>
            {
                if (n <= 8)
                {
                    removeAllQueen();
                    int first_char_line = rtxtAnswer.GetFirstCharIndexOfCurrentLine();
                    int line = rtxtAnswer.GetLineFromCharIndex(first_char_line);
                    for(int j = 0, i = 1; j < n; i++, j++)
                    {
                        setQueen(i, result[line, j]);
                    }
                }
            });
            t.IsBackground = true;
            t.Start();
        }
    }
}
