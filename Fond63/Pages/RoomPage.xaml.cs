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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Fond63.Pages
{
    /// <summary>
    /// Логика взаимодействия для RoomPage.xaml
    /// </summary>
    public partial class RoomPage : Page
    {
        public UnifercityFacultyRoom room = null;
        public RoomPage()
        {
            InitializeComponent();
            DgRooms.ItemsSource = ClassHelper.entities.UnifercityFacultyRoom.ToList();
        }

        private void BtnAddEdit_Click(object sender, RoutedEventArgs e)
        {
            AddEditWindow win = new AddEditWindow(room);
            win.Show();
        }

        private void DataGridRow_Selected(object sender, RoutedEventArgs e)
        {
            var row = (DataGridRow)sender;
            var context = row.DataContext as UnifercityFacultyRoom;
            room = context;

            if (context == null) return;
            RnUniversity.Text = context.Unifercity.Name;
            var data = ClassHelper.entities.Faculty.Count();
            RnCount.Text = data.ToString();

        }

        private void BtnDeleteRoom_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить эту комнату?", "Подтверждение", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:

                        var curRoom = ClassHelper.entities.Room.FirstOrDefault(x => x.Id == room.IdRoom);

                        var unifercityFacultyRoom = ClassHelper.entities.UnifercityFacultyRoom.Where(x => x.IdRoom == room.IdRoom);
                        ClassHelper.entities.UnifercityFacultyRoom.RemoveRange(unifercityFacultyRoom);

                        ClassHelper.entities.Room.Remove(curRoom);
                        ClassHelper.entities.SaveChanges();
                        DgRooms.Items.Refresh();
                        MessageBox.Show("Комната успешно удалена");
                        RnUniversity.Text = null;
                        RnCount.Text = null;


                        break;

                    case MessageBoxResult.No:
                        return;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
