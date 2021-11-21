using Fond63.Classes;
using Fond63.DataBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fond63.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEditWindow.xaml
    /// </summary>
    public partial class AddEditWindow : Window
    {
        public AddEditWindow(UnifercityFacultyRoom room)
        {
            InitializeComponent();

            if (room != null)
            {
                TbNameRoom.Text = room.Room.Name;
                TbHeightRoom.Text = room.Room.Height.ToString();
                TbWidthRoom.Text = room.Room.Width.ToString();
                TbLenghtRoom.Text = room.Room.Lenght.ToString();
                TbAreaRoom.Text = room.Room.Area.ToString();
                TbVolumeRoom.Text = room.Room.Volume.ToString();
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TbNameRoom.Text != "")
                {
                    var currentRoom = ClassHelper.entities.Room.FirstOrDefault(x => x.Name == TbNameRoom.Text);
                    currentRoom.Name = TbNameRoom.Text;
                    currentRoom.Height = Convert.ToInt32(TbHeightRoom.Text);
                    currentRoom.Width = Convert.ToInt32(TbWidthRoom.Text);
                    currentRoom.Lenght = Convert.ToInt32(TbLenghtRoom.Text);
                    currentRoom.Area = Convert.ToInt32(TbAreaRoom.Text);
                    currentRoom.Volume = Convert.ToInt32(TbVolumeRoom.Text);

                    ClassHelper.entities.SaveChanges();

                    MessageBox.Show("Комната успешно изменена");
                    this.Hide();
                }
                else
                {
                    Room rooms = new Room()
                    {
                        Name = TbNameRoom.Text,
                        Height = Convert.ToInt32(TbHeightRoom.Text),
                        Width = Convert.ToInt32(TbWidthRoom.Text),
                        Lenght = Convert.ToInt32(TbLenghtRoom.Text),
                        Area = Convert.ToInt32(TbAreaRoom.Text),
                        Volume = Convert.ToInt32(TbVolumeRoom.Text)
                    };

                    ClassHelper.entities.Room.Add(rooms);
                    ClassHelper.entities.SaveChanges();
                    MessageBox.Show("Комната успешно добавлена");
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}

