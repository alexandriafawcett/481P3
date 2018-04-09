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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.ResourceReferenceKeyNotFoundException;

namespace CPSC481P3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 0; i < 9; i++)
            {
                ItemTileControl thumbnail = new ItemTileControl();
                thumbnail.MouseLeftButtonDown += OnThumbnailClicked;
                //thumbnail.ItemTileImage
                this.ContentMainDishes.Children.Add(thumbnail);
            }
            for (int i = 0; i < 9; i++)
            {
                ItemTileControl thumbnail = new ItemTileControl();
                thumbnail.MouseLeftButtonDown += OnThumbnailClicked;
                this.ContentAppetizers.Children.Add(thumbnail);
            }
            for (int i = 0; i < 9; i++)
            {
                ItemTileControl thumbnail = new ItemTileControl();
                thumbnail.MouseLeftButtonDown += OnThumbnailClicked;
                this.ContentDesserts.Children.Add(thumbnail);
            }
            for (int i = 0; i < 9; i++)
            {
                ItemTileControl thumbnail = new ItemTileControl();
                thumbnail.MouseLeftButtonDown += OnThumbnailClicked;
                this.ContentSoda.Children.Add(thumbnail);
            }
            for (int i = 0; i < 9; i++)
            {
                ItemTileControl thumbnail = new ItemTileControl();
                thumbnail.MouseLeftButtonDown += OnThumbnailClicked;
                this.ContentShakes.Children.Add(thumbnail);
            }
            for (int i = 0; i < 9; i++)
            {
                ItemTileControl thumbnail = new ItemTileControl();
                thumbnail.MouseLeftButtonDown += OnThumbnailClicked;
                this.ContentCoffeeAndTea.Children.Add(thumbnail);
            }




            Storyboard sb = this.FindResource("OpenOrder") as Storyboard;
            sb.Completed += OpenOrder;
            Storyboard sb1 = this.FindResource("CloseOrder") as Storyboard;
            sb1.Completed += CloseOrder;
            Storyboard sb2 = this.FindResource("DismissWelcome") as Storyboard;
            sb2.Completed += DismissWelcomeScreen;
            Storyboard sb3 = this.FindResource("OpenFoodView") as Storyboard;
            sb3.Completed += OpenFoodView;
            Storyboard sb4 = this.FindResource("OpenDrinksView") as Storyboard;
            sb4.Completed += OpenDrinksView;

            Storyboard sb5 = this.FindResource("DisplaySodas") as Storyboard;
            sb5.Completed += DisplaySodas;
            Storyboard sb6 = this.FindResource("DisplayShakes") as Storyboard;
            sb6.Completed += DisplayShakes;
            Storyboard sb7 = this.FindResource("DisplayCof") as Storyboard;
            sb7.Completed += DisplayCof;

            Storyboard sb8 = this.FindResource("DisplayMainDishes") as Storyboard;
            sb8.Completed += DisplayMainDishes;
            Storyboard sb9 = this.FindResource("DisplayAppetizers") as Storyboard;
            sb9.Completed += DisplayAppetizers;
            Storyboard sb10 = this.FindResource("DisplayDesserts") as Storyboard;
            sb10.Completed += DisplayDesserts;

            Storyboard sb11 = this.FindResource("CloseDetailedView") as Storyboard;
            sb11.Completed += CloseDetailedView;
            Storyboard sb12 = this.FindResource("Acknowledge1") as Storyboard;
            sb12.Completed += CloseNotification1;
            Storyboard sb13 = this.FindResource("CallServer") as Storyboard;
            sb13.Completed += CallServer;
            Storyboard sb14 = this.FindResource("AcknowledgeOrder") as Storyboard;
            sb14.Completed += AcknowledgeOrder;
            Storyboard sb15 = this.FindResource("ConfirmOrder") as Storyboard;
            sb15.Completed += OrderConfirm;
            Storyboard sb16 = this.FindResource("BillOnWay") as Storyboard;
            sb16.Completed += BillComing;
            Storyboard sb17 = this.FindResource("GoToThankYou") as Storyboard;
            sb17.Completed += GoToThankU;
            Storyboard sb18 = this.FindResource("GoReviewScreen") as Storyboard;
            sb18.Completed += GoReviewScreen;
        }
        private void GoReviewScreen(object sender, EventArgs e)
        {
            this.ControlPanel.Visibility = Visibility.Hidden;
            this.SelectionScreenDrinks.Visibility = Visibility.Hidden;
            this.SelectionScreenFood.Visibility = Visibility.Hidden;
            this.BillOTW.Visibility = Visibility.Hidden;
            this.ControlPanel.Visibility = Visibility.Hidden;
            this.ReviewScreen.Visibility = Visibility.Visible;
        }
        private void GoToThankU(object sender, EventArgs e)
        {
            this.ReviewScreen.Visibility = Visibility.Hidden;
            this.ControlPanel.Visibility = Visibility.Hidden;
            this.SelectionScreenDrinks.Visibility = Visibility.Hidden;
            this.SelectionScreenFood.Visibility = Visibility.Hidden;
            this.BillOTW.Visibility = Visibility.Hidden;
            this.ThankYou.Visibility = Visibility.Visible;
        }
        private void BillComing(object sender, EventArgs e)
        {
            this.BillOTW.Visibility = Visibility.Visible;
        }
        private void OrderConfirm(object sender, EventArgs e)
        {
            this.OrderOTW.Visibility = Visibility.Visible;
        }
        private void AcknowledgeOrder(object sender, EventArgs e)
        {
            this.OrderOTW.Visibility = Visibility.Hidden;
            this.CartButton.Visibility = Visibility.Hidden;
            this.holdButtons.Visibility = Visibility.Visible;
            this.OrderScreen.Visibility = Visibility.Hidden;
        }
        private void CallServer(object sender, EventArgs e)
        {
            this.CallServerScreen.Visibility = Visibility.Visible;
        }
        private void CloseNotification1(object sender, EventArgs e)
        {
            this.CallServerScreen.Visibility = Visibility.Hidden;
        }
        private void CloseDetailedView(object sender, EventArgs e)
        {
            this.ItemDetailedView.Visibility = Visibility.Hidden;
        }
        private void OnThumbnailClicked(object sender, MouseButtonEventArgs e)
        {
            this.ItemDetailedView.Visibility = Visibility.Visible;
        }
        private void OpenOrder(object sender, EventArgs e)
        {
            this.OrderScreen.Visibility = Visibility.Visible;
        }

        private void CloseOrder(object sender, EventArgs e)
        {
            this.OrderScreen.Visibility = Visibility.Hidden;
        }
        private void DismissWelcomeScreen(object sender, EventArgs e)
        {
            this.WelcomeScreen.Visibility = Visibility.Hidden;
        }
        private void OpenFoodView(object sender, EventArgs e)
        {
            this.SelectionScreenFood.Visibility = Visibility.Visible;
            this.SelectionScreenDrinks.Visibility = Visibility.Hidden;

            this.DrinksButton.Background = Brushes.LightBlue;
            this.FoodButton.Background = Brushes.CadetBlue;
        }
        private void OpenDrinksView(object sender, EventArgs e)
        {
            this.SelectionScreenFood.Visibility = Visibility.Hidden;
            this.SelectionScreenDrinks.Visibility = Visibility.Visible;

            this.DrinksButton.Background = Brushes.CadetBlue;
            this.FoodButton.Background = Brushes.LightBlue;
        }
        private void DisplaySodas(object sender, EventArgs e)
        {
            this.ContentSoda.Visibility = Visibility.Visible;
            this.ContentCoffeeAndTea.Visibility = Visibility.Hidden;
            this.ContentShakes.Visibility = Visibility.Hidden;

            this.SodaTab.Background = Brushes.CadetBlue;
            this.CoffeeTab.Background = Brushes.LightBlue;
            this.ShakesTab.Background = Brushes.LightBlue;
        }
        private void DisplayShakes(object sender, EventArgs e)
        {
            this.ContentSoda.Visibility = Visibility.Hidden;
            this.ContentCoffeeAndTea.Visibility = Visibility.Hidden;
            this.ContentShakes.Visibility = Visibility.Visible;

            this.SodaTab.Background = Brushes.LightBlue;
            this.CoffeeTab.Background = Brushes.LightBlue;
            this.ShakesTab.Background = Brushes.CadetBlue;
        }
        private void DisplayCof(object sender, EventArgs e)
        {
            this.ContentSoda.Visibility = Visibility.Hidden;
            this.ContentCoffeeAndTea.Visibility = Visibility.Visible;
            this.ContentShakes.Visibility = Visibility.Hidden;

            this.SodaTab.Background = Brushes.LightBlue;
            this.CoffeeTab.Background = Brushes.CadetBlue;
            this.ShakesTab.Background = Brushes.LightBlue;
        }

        private void DisplayMainDishes(object sender, EventArgs e)
        {
            this.ContentMainDishes.Visibility = Visibility.Visible;
            this.ContentAppetizers.Visibility = Visibility.Hidden;
            this.ContentDesserts.Visibility = Visibility.Hidden;

            this.AppetizersTab.Background = Brushes.LightBlue;
            this.MainDishesTab.Background = Brushes.CadetBlue;
            this.DessertsTab.Background = Brushes.LightBlue;
        }
        private void DisplayAppetizers(object sender, EventArgs e)
        {
            this.ContentMainDishes.Visibility = Visibility.Hidden;
            this.ContentAppetizers.Visibility = Visibility.Visible;
            this.ContentDesserts.Visibility = Visibility.Hidden;

            this.AppetizersTab.Background = Brushes.CadetBlue;
            this.MainDishesTab.Background = Brushes.LightBlue;
            this.DessertsTab.Background = Brushes.LightBlue;
        }
        private void DisplayDesserts(object sender, EventArgs e)
        {
            this.ContentMainDishes.Visibility = Visibility.Hidden;
            this.ContentAppetizers.Visibility = Visibility.Hidden;
            this.ContentDesserts.Visibility = Visibility.Visible;

            this.AppetizersTab.Background = Brushes.LightBlue;
            this.MainDishesTab.Background = Brushes.LightBlue;
            this.DessertsTab.Background = Brushes.CadetBlue;
        }
    }
}
