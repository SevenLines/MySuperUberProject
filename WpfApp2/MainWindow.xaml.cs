using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfApp2.Models;
using WpfApp2.Views;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {


        public ObservableCollection<Auditory> Auditories 
        {
            get { return (ObservableCollection<Auditory>)GetValue(AuditoriesProperty); }
            set { SetValue(AuditoriesProperty, value); }
        }

        public static readonly DependencyProperty AuditoriesProperty =
            DependencyProperty.Register("Auditories", typeof(ObservableCollection<Auditory>), typeof(MainWindow), new PropertyMetadata(null));


        public ObservableCollection<Auditory> AudCell1
        {
            get { return (ObservableCollection<Auditory>)GetValue(AudCell1Property); }
            set { SetValue(AudCell1Property, value); }
        }

        public static readonly DependencyProperty AudCell1Property =
            DependencyProperty.Register("AudCell1", typeof(ObservableCollection<Auditory>), typeof(MainWindow), new PropertyMetadata(null));



        public MainWindow()
        {
            InitializeComponent();

            Auditories = new ObservableCollection<Auditory>{
                      new Auditory{
                          Day = 1, Pair= 1,                          
                          Discipline ="1Программирование",
                          Group ="ИСТБ-17-1",
                          Teacher ="Столбов",
                          Type =RaspisItemTypes.Lab },                        
                      new Auditory{
                          Day = 2, Pair= 2,
                          Discipline ="Мат. логика",
                          Group ="ИСТБ-17-1",
                          Teacher ="Носырева",
                          Type =RaspisItemTypes.Lection },
                      new Auditory{
                          Day = 4, Pair= 3,
                          Discipline ="3Программирование",
                          Group ="ИСТБ-17-1",
                          Teacher ="Столбов",
                          Type =RaspisItemTypes.Lab },
                      new Auditory{
                          Day = 6, Pair= 4,
                          Discipline ="Мат. логика",
                          Group ="ИСТБ-17-1",
                          Teacher ="Носырева",
                          Type =RaspisItemTypes.Lection },
                      new Auditory{
                          Day = 1, Pair= 5,
                          Discipline ="5Программирование",
                          Group ="ИСТБ-17-1",
                          Teacher ="Столбов",
                          Type =RaspisItemTypes.Lab },
                      new Auditory{
                          Day = 8, Pair= 6,
                          Discipline ="Мат. логика",
                          Group ="ИСТБ-17-1",
                          Teacher ="Носырева",
                          Type =RaspisItemTypes.Lection },
                      new Auditory{
                          Day = 7, Pair= 7,
                          Discipline ="7Программирование",
                          Group ="ИСТБ-17-1",
                          Teacher ="Столбов",
                          Type =RaspisItemTypes.Lab },
                      new Auditory{
                          Day = 3, Pair= 8,
                          Discipline ="Мат. логика",
                          Group ="ИСТБ-17-1",
                          Teacher ="Носырева",
                          Type =RaspisItemTypes.Lection },};

            foreach (var aud in Auditories)
            {
                /**
                 * Помнишь я говорил чтобы мы именовали компоненты простыми именами, 
                 * а-ля СтрокаЦифра: Row1, Row2, Row3...
                 * Вот сейчас нам это очень пригодится, мы используем метод FindName главного окна
                 * который позволяет получить доступ к компоненте на форме через его имя.
                 * as AuditoryRowVaiew -- используем так как C# сам не догадается какую компоненту вернуть
                 * а так мы ему подскажем что ее надо вернуть именно данного типа
                 * 
                 * Про использование $ ты вроде должна помнить
                 */
                var rowControl = this.FindName($"Row{aud.Day}") as AuditoryRowVaiew;
                if (rowControl != null) // на всякий проверям что компонента нашлась
                {
                    /**
                     * А тут чистой воды колдунство, мы получаем доступа к Свойству компоненты по имени,
                     * имя формируем динамически, и опять нам в помощь именование СтрокаЦифра
                     * Вместо Цифры подставляем НомерПары-1, опять же помнишь я говорил что лучше нумеровать с одно
                     */
                    var property = rowControl.GetType().GetProperty($"AudCell{aud.Pair - 1}");

                    // ну и короче получив свойство мы ему присваиваем инфу по ячейки
                    property.SetValue(rowControl, aud);
                }
            }

            DataContext = this;
        }
    }
}
