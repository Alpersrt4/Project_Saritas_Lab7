using System.Windows;
using Core;

namespace WpfUI
{
    public partial class AddDialog : Window
    {
        public SimpleTask NewTask { get; private set; }

        public AddDialog()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            // Kutulara girilen verilerden taptaze bir SimpleTask oluşturuyoruz
            NewTask = new SimpleTask
            {
                Id = new System.Random().Next(100, 999), // Rastgele ID
                Title = TxtTitle.Text,
                Hours = int.TryParse(TxtHours.Text, out int h) ? h : 0
            };

            this.DialogResult = true; // Pencereyi başarıyla kapat ve ana ekrana dön
        }
    }
}