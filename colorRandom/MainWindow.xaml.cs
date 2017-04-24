using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;


namespace colorRandom
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd = new Random();
        int numer = 0;
        int statN = 0;
        int statR = 0;
        int statC = 0;
        int statZI = 0;
        int statB = 0;
        int statF = 0;
        int statZ = 0;
        int statP = 0;
        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int color = rnd.Next(1, 9);
            if (color == 1)
            {
                kolorLista niebieski = new kolorLista(new SolidColorBrush(Colors.Blue), "Niebieski");
                kwadrat.Fill = niebieski.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = niebieski.nazwa.ToString();
                listView.Items.Insert(0,niebieski);
                UpdateLayout();
                statN++;

            }
            else if (color == 2)
            {
                kolorLista rozowy = new kolorLista(new SolidColorBrush(Colors.Pink), "Różowy");
                kwadrat.Fill = rozowy.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = rozowy.nazwa.ToString();
                listView.Items.Insert(0, rozowy);
                UpdateLayout();
                statR++;
            }
            else if (color == 3)
            {
                kolorLista czerwony = new kolorLista(new SolidColorBrush(Colors.Red), "Czerwony");
                kwadrat.Fill = czerwony.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = czerwony.nazwa.ToString();
                listView.Items.Insert(0, czerwony);
                UpdateLayout();
                statC++;
            }
            else if (color == 4)
            {
                kolorLista zielony = new kolorLista(new SolidColorBrush(Colors.Green), "Zielony");
                kwadrat.Fill = zielony.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = zielony.nazwa.ToString();
                listView.Items.Insert(0, zielony);
                UpdateLayout();
                statZI++;
            }
            else if (color == 5)
            {
                kolorLista brazowy = new kolorLista(new SolidColorBrush(Colors.Brown), "Brązowy");
                kwadrat.Fill = brazowy.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = brazowy.nazwa.ToString();
                listView.Items.Insert(0, brazowy);
                UpdateLayout();
                statB++;
            }
            else if (color == 6)
            {
                kolorLista fioletowy = new kolorLista(new SolidColorBrush(Colors.Purple), "Fioletowy");
                kwadrat.Fill = fioletowy.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = fioletowy.nazwa.ToString();
                listView.Items.Insert(0, fioletowy);
                UpdateLayout();
                statF++;
            }
            else if (color == 7)
            {
                kolorLista zolty = new kolorLista(new SolidColorBrush(Colors.Yellow), "Żółty");
                kwadrat.Fill = zolty.kolor;
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = zolty.nazwa.ToString();
                listView.Items.Insert(0, zolty);
                UpdateLayout();
                statZ++;
            }
            else if (color == 8)
            {
                kolorLista pomaranczowy = new kolorLista(new SolidColorBrush(Colors.Orange), "Pomarańczowy");
                kwadrat.Fill = new SolidColorBrush(Colors.Orange);
                numer++;
                text.Text = numer.ToString();
                nazwaKoloru.Text = pomaranczowy.nazwa.ToString();
                listView.Items.Insert(0, pomaranczowy);
                UpdateLayout();
                statP++;
            }
            else
            {
                kwadrat.Fill = new SolidColorBrush(Colors.White);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            kwadrat.Fill = new SolidColorBrush(Colors.White);
            numer = 0;
            text.Text = numer.ToString();
            listView.Items.Clear();
            nazwaKoloru.Text = "";

            statN = 0;
            statR = 0;
            statC = 0;
            statZI = 0;
            statB = 0;
            statF = 0;
            statZ = 0;
            statP = 0;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.L)
            {
                button_Click(sender, e);
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F12)
            {
                MessageBoxResult result = MessageBox.Show("Niebieski: "+statN.ToString()+"\nRóżowy: "+statR.ToString()+"\nCzerwony: "+statC.ToString()+"\nZielony: "+statZI.ToString()+"\nBrązowy: "+statB.ToString()+"\nFioletowy: "+statF.ToString()+"\nŻółty: "+statZ.ToString()+"\nPomarańczowy: "+statP.ToString()+"", "DEBUG - Statystyki wystąpień kolorów");
            }
        }

        
    }
}
