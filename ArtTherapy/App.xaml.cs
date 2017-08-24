using ArtTherapy.Pages.MenuPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Phone.UI.Input;
using Windows.System;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

namespace ArtTherapy
{
    /// <summary>
    /// Обеспечивает зависящее от конкретного приложения поведение, дополняющее класс Application по умолчанию.
    /// </summary>
    sealed partial class App : Application
    {
        public static bool IsPhone => ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0);

        /// <summary>
        /// Инициализирует одноэлементный объект приложения.  Это первая выполняемая строка разрабатываемого
        /// кода; поэтому она является логическим эквивалентом main() или WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();
            this.Suspending += OnSuspending;
        }

        /// <summary>
        /// Вызывается при обычном запуске приложения пользователем.  Будут использоваться другие точки входа,
        /// например, если приложение запускается для открытия конкретного файла.
        /// </summary>
        /// <param name="e">Сведения о запросе и обработке запуска.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;

            // Не повторяйте инициализацию приложения, если в окне уже имеется содержимое,
            // только обеспечьте активность окна
            if (rootFrame == null)
            {
                // Создание фрейма, который станет контекстом навигации, и переход к первой странице
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Загрузить состояние из ранее приостановленного приложения
                }

                // Размещение фрейма в текущем окне
                Window.Current.Content = rootFrame;
            }

            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    // Если стек навигации не восстанавливается для перехода к первой странице,
                    // настройка новой страницы путем передачи необходимой информации в качестве параметра
                    // параметр
                    rootFrame.Navigate(typeof(MenuPage), e.Arguments);
                }

                SetDefaultSettings(rootFrame);

                // Обеспечение активности текущего окна
                Window.Current.Activate();
            }
        }

        private void SetDefaultSettings(Frame rootFrame)
        {
            if (rootFrame != null)
            {
                // Фон фрейма
                rootFrame.Background = new SolidColorBrush(Colors.Black);

                //BitmapImage image = new BitmapImage(
                //new Uri("ms-appx:///Assets/bg@3x.png", UriKind.RelativeOrAbsolute));

                //rootFrame.Background = new ImageBrush()
                //{
                //    ImageSource = image,
                //    Stretch = Stretch.None
                //};

                // Реализация собитий кнопки "Назад"
                if (IsPhone)
                     HardwareButtons.BackPressed += (sender, ev) =>
                    {
                        ev.Handled = true;
                        //if (RootFrame.Content is ISplitPage page)
                        //{
                        //    if (page.ContentFrame.CanGoBack)
                        //        page.ResetNavigation();
                        //}
                        if (rootFrame.CanGoBack)
                            rootFrame.GoBack();
                    };
                else
                    rootFrame.KeyUp += (sender, ev) =>
                    {
                        if (ev.Key == VirtualKey.Escape)
                        {
                            //if (RootFrame.Content is ISplitPage page)
                            //{
                            //    if (page.ContentFrame.CanGoBack)
                            //        page.ResetNavigation();
                            //}
                            if (rootFrame.CanGoBack)
                                rootFrame.GoBack();
                        }
                    };
            }

            // Установка минимального размера окна
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(300, 300));

            //Цвет верхней панели и кнопок для пк
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonHoverBackgroundColor = Colors.Gray;
                    titleBar.ButtonHoverForegroundColor = Colors.White;
                    titleBar.ButtonBackgroundColor = Colors.Black;
                    titleBar.ButtonForegroundColor = Colors.White;
                    titleBar.BackgroundColor = Colors.Black;
                    titleBar.ForegroundColor = Colors.White;
                }
            }

            //Цвет верхней панели для телефона
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();
                if (statusBar != null)
                {
                    statusBar.ForegroundColor = Colors.White;
                    statusBar.BackgroundColor = Colors.Black;
                    statusBar.BackgroundOpacity = 1;
                }
            }

            // Запуск мобильного приложения в режиме FullScreen
            //if (ApiInformation.IsApiContractPresent("Windows.Phone.PhoneContract", 1, 0))
            //    ApplicationView.GetForCurrentView().TryEnterFullScreenMode();
        }

        /// <summary>
        /// Вызывается в случае сбоя навигации на определенную страницу
        /// </summary>
        /// <param name="sender">Фрейм, для которого произошел сбой навигации</param>
        /// <param name="e">Сведения о сбое навигации</param>
        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Вызывается при приостановке выполнения приложения.  Состояние приложения сохраняется
        /// без учета информации о том, будет ли оно завершено или возобновлено с неизменным
        /// содержимым памяти.
        /// </summary>
        /// <param name="sender">Источник запроса приостановки.</param>
        /// <param name="e">Сведения о запросе приостановки.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Сохранить состояние приложения и остановить все фоновые операции
            deferral.Complete();
        }
    }
}