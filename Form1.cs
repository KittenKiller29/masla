using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace masla
{
    public partial class Form1 : Form
    {
        int check = 0, step = 0, check1 = 0, check2 = 0, check3 = 0, check4 = 0, check5 = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            button1.Visible = true;
            pictureBox1.Image = null;
            label1.Text = "По какому критерию Вы бы хотели подобрать себе эфирное масло?";
            radioButton1.Visible = true;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;
            radioButton9.Visible = false;
            radioButton10.Visible = false;
            radioButton11.Visible = false;
            radioButton12.Visible = false;
            radioButton13.Visible = false;
            radioButton14.Visible = false;
            radioButton15.Visible = false;
            check = 0;
            check1 = 0;
            check2 = 0;
            check3 = 0;
            step = 0;
            radioButton1.Text = "По назначению";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.ForeColor = System.Drawing.Color.FromArgb(16, 16, 16);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;

            switch (step)
            {
                case 0:
                    switch (check)
                    {
                        case 0:
                            step--;
                            break;
                        case 1:
                            label1.Text = "В каких целях Вы планируете использовать эфирное масло?";
                            radioButton2.Visible = true;
                            check = 0;
                            check1 = 1;
                            radioButton1.Text = "Для оздоровительных целей";
                            radioButton2.Text = "Для практических целей";
                            break;

                    }
                    step++;
                    break;
                case 1:
                    switch (check1)
                    {
                        case 0:
                            step--;
                            break;
                        default:
                            switch (check)
                            {
                                case 0:
                                    step--;
                                    break;
                                case 1:
                                    radioButton2.Visible = true;
                                    label1.Text = "Назначение";
                                    radioButton1.Text = "Гормоны";
                                    radioButton2.Text = "Дыхание";
                                    radioButton3.Visible = true;
                                    radioButton3.Text = "Кости и мышцы";
                                    radioButton15.Text = "Сердце и сосуды";
                                    radioButton15.Visible = true;
                                    radioButton5.Text = "Иммунитет";
                                    radioButton4.Text = "Кожа и волосы";
                                    radioButton7.Text = "Нервная система";
                                    radioButton4.Visible = true;
                                    radioButton5.Visible = true;
                                    radioButton7.Visible = true;
                                    radioButton6.Text = "Пищеварение";
                                    radioButton8.Text = "Эмоциональный баланс";
                                    radioButton6.Visible = true;
                                    radioButton8.Visible = true;
                                    check = 0;
                                    check2 = 1;
                                    break;


                                case 2:
                                    radioButton2.Visible = true;
                                    label1.Text = "Для чего вам нужно эфирное масло?";
                                    radioButton1.Text = "Для кулинарии";
                                    radioButton2.Text = "Для использования в качестве афродизиака";
                                    radioButton3.Visible = true;
                                    radioButton3.Text = "Для дезинфекции";
                                    radioButton15.Text = "Для детей";
                                    radioButton15.Visible = true;
                                    radioButton5.Text = "Для сна";
                                    radioButton5.Visible = true;
                                    radioButton4.Visible = true;
                                    radioButton4.Text = "Для защиты от насекомых";
                                    check = 0;
                                    check2 = 2;
                                    break;
                            }
                            break;
                    }
                    step++;
                    break;
                case 2:
                    switch (check)
                    {
                        case 0:
                            step--;
                            break;
                        default:
                            label1.Text = "Какой аромат вас интересует?";
                            radioButton1.Text = "Успокаивающий";
                            radioButton2.Text = "Освежащий";
                            radioButton3.Text = "Согревающий";
                            radioButton15.Text = "Яркий";
                            radioButton3.Visible = true;
                            radioButton15.Visible = true;
                            radioButton5.Visible = false;
                            radioButton6.Visible = false;
                            radioButton4.Visible = false;
                            radioButton8.Visible = false;
                            radioButton7.Visible = false;
                            switch (check2)
                            {
                                case 1:
                                    switch (check)
                                    {
                                        case 0:
                                            step--;
                                            break;
                                        case 1:
                                            check = 0;
                                            check3 = 1;
                                            break;
                                        case 2:
                                            check = 0;
                                            check3 = 2;
                                            break;
                                        case 3:
                                            check = 0;
                                            check3 = 3;
                                            break;
                                        case 4:
                                            check = 0;
                                            check3 = 4;
                                            break;
                                        case 5:
                                            check = 0;
                                            check3 = 5;
                                            break;
                                        case 6:
                                            check = 0;
                                            check3 = 6;
                                            break;
                                        case 7:
                                            check = 0;
                                            check3 = 7;
                                            break;
                                        case 8:
                                            check = 0;
                                            check3 = 8;
                                            break;
                                        case 9:
                                            check = 0;
                                            check3 = 9;
                                            break;
                                    }
                                    break;
                                case 2:
                                    switch (check)
                                    {
                                        case 0:
                                            step--;
                                            break;
                                        case 1:
                                            check = 0;
                                            check3 = 10;
                                            break;
                                        case 2:
                                            check = 0;
                                            check3 = 11;
                                            break;
                                        case 3:
                                            check = 0;
                                            check3 = 12;
                                            break;
                                        case 4:
                                            check = 0;
                                            check3 = 13;
                                            break;
                                        case 5:
                                            check = 0;
                                            check3 = 14;
                                            break;
                                        case 6:
                                            check = 0;
                                            check3 = 15;
                                            break;

                                    }
                                    break;

                            }
                            break;
                    }
                    step++;
                    break;
                case 3:
                    if (check == 0)
                        step--;
                    else if (check == 1)
                    {
                        label1.Text = "Выберите успокаивающий аромат";
                        radioButton1.Text = "Бальзамический";
                        radioButton2.Text = "Древесный";
                        radioButton3.Text = "Зелень";
                        radioButton15.Text = "Земляной";
                        radioButton5.Text = "Кожа";
                        radioButton4.Text = "Травяной";
                        radioButton7.Text = "Хвойный";
                        radioButton4.Visible = true;
                        radioButton5.Visible = true;
                        radioButton7.Visible = true;
                        check = 0;
                        switch (check3)
                        {
                            case 1:
                                check4 = 1;
                                break;
                            case 2:
                                check4 = 5;
                                break;
                            case 3:
                                check4 = 9;
                                break;
                            case 4:
                                check4 = 13;
                                break;
                            case 5:
                                check4 = 17;
                                break;
                            case 6:
                                check4 = 21;
                                break;
                            case 7:
                                check4 = 25;
                                break;
                            case 8:
                                check4 = 29;
                                break;
                            case 9:
                                check4 = 33;
                                break;
                            case 10:
                                check4 = 37;
                                break;
                            case 11:
                                check4 = 41;
                                break;
                            case 12:
                                check4 = 45;
                                break;
                            case 13:
                                check4 = 49;
                                break;
                            case 14:
                                check4 = 53;
                                break;
                            case 15:
                                check4 = 57;
                                break;
                        }
                    }
                    else if (check == 2)
                    {
                        label1.Text = "Выберите освежающий аромат";
                        radioButton1.Text = "Воздушный";
                        radioButton2.Text = "Камфорный";
                        radioButton3.Text = "Легкий";
                        radioButton15.Text = "Мятный";
                        radioButton5.Text = "Свежий";
                        radioButton4.Text = "Чистый";
                        check = 0;
                        radioButton4.Visible = true;
                        radioButton5.Visible = true;
                        switch (check3)
                        {
                            case 1:
                                check4 = 2;
                                break;
                            case 2:
                                check4 = 6;
                                break;
                            case 3:
                                check4 = 10;
                                break;
                            case 4:
                                check4 = 14;
                                break;
                            case 5:
                                check4 = 18;
                                break;
                            case 6:
                                check4 = 22;
                                break;
                            case 7:
                                check4 = 26;
                                break;
                            case 8:
                                check4 = 30;
                                break;
                            case 9:
                                check4 = 34;
                                break;
                            case 10:
                                check4 = 38;
                                break;
                            case 11:
                                check4 = 42;
                                break;
                            case 12:
                                check4 = 46;
                                break;
                            case 13:
                                check4 = 50;
                                break;
                            case 14:
                                check4 = 54;
                                break;
                            case 15:
                                check4 = 58;
                                break;
                        }

                    }
                    else if (check == 3)
                    {
                        label1.Text = "Выберите согревающий аромат";
                        radioButton1.Text = "Горячий";
                        radioButton2.Text = "Густой";
                        radioButton3.Text = "Душистый";
                        radioButton15.Text = "Дымный";
                        radioButton5.Text = "Насыщенный";
                        radioButton4.Text = "Острый";
                        radioButton7.Text = "Пряный";
                        radioButton6.Text = "Сенной";
                        radioButton8.Text = "Сухой";
                        radioButton9.Text = "Теплый";
                        radioButton11.Text = "Терпкий";
                        radioButton4.Visible = true;
                        radioButton5.Visible = true;
                        radioButton7.Visible = true;
                        radioButton6.Visible = true;
                        radioButton8.Visible = true;
                        radioButton9.Visible = true;
                        radioButton11.Visible = true;
                        check = 0;
                        switch (check3)
                        {
                            case 1:
                                check4 = 3;
                                break;
                            case 2:
                                check4 = 7;
                                break;
                            case 3:
                                check4 = 11;
                                break;
                            case 4:
                                check4 = 15;
                                break;
                            case 5:
                                check4 = 19;
                                break;
                            case 6:
                                check4 = 23;
                                break;
                            case 7:
                                check4 = 27;
                                break;
                            case 8:
                                check4 = 31;
                                break;
                            case 9:
                                check4 = 35;
                                break;
                            case 10:
                                check4 = 39;
                                break;
                            case 11:
                                check4 = 43;
                                break;
                            case 12:
                                check4 = 47;
                                break;
                            case 13:
                                check4 = 51;
                                break;
                            case 14:
                                check4 = 55;
                                break;
                            case 15:
                                check4 = 59;
                                break;
                        }
                    }
                    else if (check == 4)
                    {
                        label1.Text = "Выберите яркий аромат";
                        radioButton1.Text = "Жасмин";
                        radioButton2.Text = "Карамель";
                        radioButton3.Text = "Коричный";
                        radioButton15.Text = "Лакричный";
                        radioButton5.Text = "Лимонный";
                        radioButton4.Text = "Медовый";
                        radioButton7.Text = "Мускусный";
                        radioButton6.Text = "Нежный";
                        radioButton8.Text = "Ореховый";
                        radioButton9.Text = "Розовый";
                        radioButton11.Text = "Сладкий";
                        radioButton10.Text = "Фруктовый";
                        radioButton14.Text = "Цветочный";
                        radioButton13.Text = "Цитрусовый";
                        radioButton4.Visible = true;
                        radioButton5.Visible = true;
                        radioButton7.Visible = true;
                        radioButton6.Visible = true;
                        radioButton8.Visible = true;
                        radioButton9.Visible = true;
                        radioButton11.Visible = true;
                        radioButton10.Visible = true;
                        radioButton14.Visible = true;
                        radioButton13.Visible = true;
                        check = 0;
                        switch (check3)
                        {
                            case 1:
                                check4 = 4;
                                break;
                            case 2:
                                check4 = 8;
                                break;
                            case 3:
                                check4 = 12;
                                break;
                            case 4:
                                check4 = 16;
                                break;
                            case 5:
                                check4 = 20;
                                break;
                            case 6:
                                check4 = 24;
                                break;
                            case 7:
                                check4 = 28;
                                break;
                            case 8:
                                check4 = 32;
                                break;
                            case 9:
                                check4 = 36;
                                break;
                            case 10:
                                check4 = 40;
                                break;
                            case 11:
                                check4 = 44;
                                break;
                            case 12:
                                check4 = 48;
                                break;
                            case 13:
                                check4 = 52;
                                break;
                            case 14:
                                check4 = 56;
                                break;
                            case 15:
                                check4 = 60;
                                break;
                        }
                    }
                    step++;
                    break;


                case 4:
                    if (check == 0)
                        step--;
                    else
                    {
                        button1.Visible = false;
                        textBox1.Visible = true;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton6.Visible = false;
                        radioButton7.Visible = false;
                        radioButton8.Visible = false;
                        radioButton9.Visible = false;
                        radioButton10.Visible = false;
                        radioButton11.Visible = false;
                        radioButton12.Visible = false;
                        radioButton13.Visible = false;
                        radioButton14.Visible = false;
                        textBox1.BackColor = Color.FromKnownColor(KnownColor.Control);
                        textBox1.ForeColor = Color.Black;
                        textBox1.ReadOnly = true;
                        radioButton15.Visible = false;
                        radioButton13.Visible = false;
                        switch (check4)
                        {
                            case 0:
                                step--;
                                break;
                            case 1:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Immortelle Anti-aging Blend / «Иммортель», Антивозрастная смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-immortelle-anti-aging-blend.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: " + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        //textBox1.Text = "Артикул: " + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Кориандр (Coriandrum sativum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "InTune® Focus Blend / «Настроенность», смесь масел для концентрации внимания";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Clarycalm Monthly Blend for women / «Ясность и спокойствие», смесь эфирных масел для женщин";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Clarycalm Monthly Blend for women / «Ясность и спокойствие», смесь эфирных масел для женщин";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 2:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Motivate Encouraging Blend / «Мотивация», Ободряющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Motivate Encouraging Blend / «Мотивация», Ободряющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Immortelle Anti-aging Blend / «Иммортель», Антивозрастная смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 3:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Мирра (Commiphora myrrha)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Ветивер (Vetiveria zizanioides)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Иланг-Иланг (Cananga odorata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Zendocrine® Detoxification Blend / «Зендокрин», смесь масел для детоксикации";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "InTune® Focus Blend / «Настроенность», смесь масел для концентрации внимания";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Мирра (Commiphora myrrha)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Whisper Blend for Women / «Шепот», смесь масел для женщин";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 4:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Ветивер (Vetiveria zizanioides)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Фенхель (Foeniculum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Фенхель (Foeniculum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Whisper Blend for Women / «Шепот», смесь масел для женщин";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Adaptiv Blend / Адаптив, успокаивающая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Zendocrine® Detoxification Blend / «Зендокрин», смесь масел для детоксикации.";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Клеточный комплекс DDR Prime";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 5:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Черная ель (Picea mariana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Кедр (Juniperus virginiana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Чайное дерево";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "dōTERRA Kids Thinker™ 10 ml / «Мыслитель»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Гвоздика (Eugenia caryophyllata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Northern Escape / Смесь масел «Северный лес»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;

                                }
                                break;
                            case 6:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Смесь Breathe";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Tamer Touch Blend / «Укротитель»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Лимон (Citrus limonlum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Лимон (Citrus limonlum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                }
                                break;
                            case 7:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Кардамон (Elettaria Cardamomum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Сандаловое дерево (Santalum album)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Holiday Joy Essential Blend Oil / «Праздничное удовольствие»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Лайм (Citrus aurantifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;

                                }
                                break;
                            case 8:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Lemon Eucalyptus / Лимонный эвкалипт";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Кедр (Juniperus virginiana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Holiday Joy Essential Blend Oil / «Праздничное удовольствие»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Magnolia Touch / Магнолия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Magnolia Touch / Магнолия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Лайм (Citrus aurantifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;

                                }
                                break;
                            case 9:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Balance® Grounding Blend / «Баланс» Смесь для установления равновесия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Чайное дерево";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Тимьян (чабрец) (Thymus vulgaris)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Пихта сибирская / Siberian Fir (Abies sibirica).";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;

                                }
                                break;
                            case 10:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Balance® Grounding Blend / «Баланс» Смесь для установления равновесия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Deep Blue";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "AromaTouch Massage Blend, dо̄TERRA (ATT) / «АромаТач», смесь эфирных масел для массажа";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Lemon Eucalyptus / Лимонный эвкалипт";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Пихта сибирская / Siberian Fir (Abies sibirica).";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                }
                                break;
                            case 11:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Тимьян (чабрец) (Thymus vulgaris)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Лемонграсс (Cymbopogon flexuosus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Базилик (Ocimum basilicum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "Бессмертник (Helichrysum italicum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Майоран (Origanum majorana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 12:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Lemon Eucalyptus / Лимонный эвкалипт";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Кедр (Juniperus virginiana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Кедр (Juniperus virginiana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Тимьян (чабрец) (Thymus vulgaris)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Лемонграсс (Cymbopogon flexuosus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + ""; check = 0;
                                        break;

                                }
                                break;
                            case 13:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Майоран (Origanum majorana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Turmeric / Куркума (Curcuma longa)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Гвоздика (Eugenia caryophyllata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Мелисса (Melissa officinalis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 14:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Мелисса (Melissa officinalis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Кипарис (Cupressus sempervirens)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 15:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Иланг-Иланг (Cananga odorata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Turmeric / Куркума (Curcuma longa)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "Бессмертник (Helichrysum italicum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Базилик (Ocimum basilicum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 16:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Бессмертник (Helichrysum italicum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Иланг-Иланг (Cananga odorata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Грейпфрут (Citrus X paradisi)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Клеточный комплекс DDR Prime";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 17:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Голубая пижма (Tanacetum annuum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Сандаловое дерево (Santalum album)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Turmeric / Куркума (Curcuma longa)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Чайное дерево";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Zendocrine® Detoxification Blend / «Зендокрин», смесь масел для детоксикации";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 18:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Смесь Breathe";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Защитная смесь On Guard";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "AromaTouch Massage Blend, dо̄TERRA (ATT) / «АромаТач», смесь эфирных масел для массажа";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Смесь Breathe";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Ладан (Boswellia Carterii)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 19:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Мирра (Commiphora myrrha)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Тимьян (чабрец) (Thymus vulgaris)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Лемонграсс (Cymbopogon flexuosus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Пачули (Pogostemon cablin)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Корица (Cinnamomum zeylanicum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Кассия (Cinnamomum cassia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Мирра (Commiphora myrrha)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Кассия (Cinnamomum cassia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Мандарин / Tangerine (Citrus reticulata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 20:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Кассия (Cinnamomum cassia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Лимон (Citrus limonlum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "Голубая пижма (Tanacetum annuum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Цитрусовая нега, тонизирующая смесь (CITRUS BLISS INVIGORATING BLEND)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Green Mandarin / Зеленый мандарин (Citrus nobilis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Zendocrine® Detoxification Blend / «Зендокрин», смесь масел для детоксикации";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Цитрусовая нега, тонизирующая смесь (CITRUS BLISS INVIGORATING BLEND)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 21:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Голубая пижма (Tanacetum annuum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Копайба (Copaifera)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Чайное дерево";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Гвоздика (Eugenia caryophyllata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Розмарин (Rosmarinus officinalis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Clarycalm Monthly Blend for women / «Ясность и спокойствие», смесь эфирных масел для женщин";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 22:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Эвкалипт (Eucalyptus radiata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Эвкалипт (Eucalyptus radiata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Мята перечная (Mentha peperita)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Дикий апельсин (Citrus sinensis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                }
                                break;
                            case 23:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Бергамот (Citrus bergamia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Гвоздика (Eugenia caryophyllata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 24:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Цитронелла (Cymbopogon winterianus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "Голубая пижма (Tanacetum annuum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Цитронелла (Cymbopogon winterianus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Дикий апельсин (Citrus sinensis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Голубая пижма (Tanacetum annuum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Бергамот (Citrus bergamia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Дикий апельсин (Citrus sinensis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 25:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Можжевельник (Juniperus communis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "TerraShield Repellent Blend, Outdoor Blend / «Щит Земли»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Yoga Align Blend/ «Равновесие», центрирующая смесь для йоги, умиротворяющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Yoga Anchor Blend/ «Опора», укрепление, стабилизирующая смесь для йоги";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Yoga Align Blend/ «Равновесие», центрирующая смесь для йоги, умиротворяющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Northern Escape / Смесь масел «Северный лес»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 26:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Balance® Grounding Blend / «Баланс» Смесь для установления равновесия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Защитная смесь On Guard";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "PastTense® Tension Blend «Долой напряжение», расслабляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "PastTense® Tension Blend «Долой напряжение», расслабляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Motivate Encouraging Blend / «Мотивация», Ободряющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 27:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Имбирь (Zingiber officinale)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Ветивер (Vetiveria zizanioides)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Yoga Anchor Blend/ «Опора», укрепление, стабилизирующая смесь для йоги";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Черный перец (Piper nigrum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Turmeric / Куркума (Curcuma longa)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Мирра (Commiphora myrrha)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "SERENITY CALMING BLEND / «Безмятежность», успокаивающая смесь, смесь для отдыха";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 28:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Ветивер (Vetiveria zizanioides)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Цитронелла (Cymbopogon winterianus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Console Comforting Blend / «Утешение», успокаивающая смесь масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "Голубая пижма (Tanacetum annuum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Кедр (Juniperus virginiana)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Цитронелла (Cymbopogon winterianus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Peace Reassuring Blend / «Спокойствие», умиротворяющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Green Mandarin / Зеленый мандарин (Citrus nobilis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Римская ромашка (Anthemis nobilis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Yoga Arise Blend/ «Восхождение», зарождение, просвещающая смесь для йоги, просветляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 29:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Можжевельник (Juniperus communis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Можжевельник (Juniperus communis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Кориандр (Coriandrum sativum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Масло сельдерея. (Apium graveolens)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Гвоздика (Eugenia caryophyllata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Кинза (Coriandrum sativum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;

                                }
                                break;
                            case 30:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "PURIFY CLEANSING BLEND / «Очищение», очищающая смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Орегано (Origanum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Tamer Touch Blend / «Укротитель»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "PURIFY CLEANSING BLEND / «Очищение», очищающая смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Лимон (Citrus limonlum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 31:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Имбирь (Zingiber officinale)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Лемонграсс (Cymbopogon flexuosus)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Кинза (Coriandrum sativum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Смесь DigestZen для улучшения пищеварения";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Turmeric / Куркума (Curcuma longa)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Лайм (Citrus aurantifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 32:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Кассия (Cinnamomum cassia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Фенхель (Foeniculum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Лимон (Citrus limonlum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Фенхель (Foeniculum vulgare)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Neroli Touch / «Нероли», смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Active Botanical Nutritive Duo, Yarrow | Pom (Тысячелистник | Гранат)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Green Mandarin / Зеленый мандарин (Citrus nobilis)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Лимон (Citrus limonlum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 33:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Magnolia Touch / Магнолия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Forgive Renewing Blend / «Прощение», Обновляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Yoga Align Blend/ «Равновесие», центрирующая смесь для йоги, умиротворяющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Туя складчатая (Thuja plicata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "dōTERRA Kids Brave™ / «Храбрый»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "PURIFY CLEANSING BLEND / «Очищение», очищающая смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Northern Escape / Смесь масел «Северный лес»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 34:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "PURIFY CLEANSING BLEND / «Очищение», очищающая смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Мята садовая (Mentha spicata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "PastTense® Tension Blend «Долой напряжение», расслабляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Immortelle Anti-aging Blend / «Иммортель», Антивозрастная смесь эфирных масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 35:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "Лаванда (Lavandula angustifolia)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "Ветивер (Vetiveria zizanioides)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "Passion Inspiring Blend / «Страсть», Вдохновляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "TerraShield Repellent Blend, Outdoor Blend / «Щит Земли»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Yoga Anchor Blend/ «Опора», укрепление, стабилизирующая смесь для йоги";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "Сандаловое дерево (Santalum album)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Holiday Joy Essential Blend Oil / «Праздничное удовольствие»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Мандарин / Tangerine (Citrus reticulata)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 36:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "Jasmine Touch / Жасмин (Jasminum grandiflorum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "Ветивер (Vetiveria zizanioides)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "dōTERRA Kids Stronger™ / «Стойкость»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "Гавайское сандаловое дерево (Santalum paniculatum)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "Console Comforting Blend / «Утешение», успокаивающая смесь масел";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "К сожалению, невозможно подобрать масло по выбранным Вами критериям";
                                        //pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Вернитесь к началу и попробуйте другие варианты";
                                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "Герань (Pelargonium graveolens)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "Holiday Joy Essential Blend Oil / «Праздничное удовольствие»";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "Magnolia Touch / Магнолия";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "Yoga Arise Blend/ «Восхождение», зарождение, просвещающая смесь для йоги, просветляющая смесь";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "Цитрусовая нега, тонизирующая смесь (CITRUS BLISS INVIGORATING BLEND)";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 37:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "37? Air-x / Смесь масел Air";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "2";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "3";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "4";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "5";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "6";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "7";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 38:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "38? 8";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "9";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "10";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "11";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "12";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "13";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 39:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "39? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 40:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "40? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "234";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 41:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "41? Air-x / Смесь масел Air";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "2";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "3";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "4";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "5";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "6";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "7";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 42:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "42? 8";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "9";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "10";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "11";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "12";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "13";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 43:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "43? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 44:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "44? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "234";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 45:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "45? Air-x / Смесь масел Air";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "2";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "3";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "4";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "5";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "6";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "7";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 46:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "46? 8";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "9";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "10";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "11";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "12";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "13";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 47:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "47? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 48:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "48? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "234";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 49:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "49? Air-x / Смесь масел Air";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "2";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "3";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "4";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "5";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "6";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "7";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 50:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "50? 8";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "9";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "10";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "11";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "12";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "13";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 51:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "51? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 52:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "52? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "234";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 53:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "53? Air-x / Смесь масел Air";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "2";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "3";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "4";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "5";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "6";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "7";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 54:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "54? 8";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "9";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "10";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "11";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "12";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "13";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 55:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "55? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 56:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "56? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "234";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 57:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "57? Air-x / Смесь масел Air";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "2";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "3";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "4";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "5";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "6";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "7";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 58:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "58? 8";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "9";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "10";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "11";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "12";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "13";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                }
                                break;
                            case 59:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "59? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;
                            case 60:
                                switch (check)
                                {
                                    case 1:
                                        label1.Text = "60? 14";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 2:
                                        label1.Text = "15";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 3:
                                        label1.Text = "16";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 4:
                                        label1.Text = "17";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 5:
                                        label1.Text = "18";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 6:
                                        label1.Text = "19";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 7:
                                        label1.Text = "20";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 8:
                                        label1.Text = "21";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/smes-masel-air-x-oil.jpg");
                                        textBox1.Text = "Артикул: 60215527" + "\r" + "\n" + "\r" + "\n" + "Air-X освежает воздух, наполняя его яркими цитрусовыми и древесными ароматами с травянистыми нотками." + "\r" + "\n" + "\r" + "\n" + "Применение:  ароматическое, внутреннее, наружное, не разбавлять, разбавлять" + "\r" + "\n" + "Назначение:  дыхание, нервная система, эмоциональный баланс" + "\r" + "\n" + "Состав:  грейпфрут, кардамон, ладан, лицея, танжерин" + "\r" + "\n" + "Аромат:  сладкий" + "\r" + "\n" + "";
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        check = 0;
                                        break;
                                    case 9:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 10:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 11:
                                        label1.Text = "24";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 12:
                                        label1.Text = "22";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 13:
                                        label1.Text = "23";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;
                                    case 14:
                                        label1.Text = "234";
                                        pictureBox1.Load("https://aromavita.club/wp-content/uploads/efirnoe-maslo-vetiver.jpg");
                                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                                        textBox1.Text = "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "" + "\r" + "\n" + "";
                                        check = 0;
                                        break;

                                }
                                break;

                        }
                    }
                    step++;
                    break;

            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            check = 3;
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            check = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            check = 5;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            check = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            check = 7;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            check = 8;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            check = 9;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            check = 10;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            check = 11;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            check = 12;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            check = 13;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            check = 14;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            check = 15;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check = 1;
        }
    }
}
