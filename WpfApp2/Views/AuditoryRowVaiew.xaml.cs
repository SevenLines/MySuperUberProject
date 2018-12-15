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
using WpfApp2.Models;

namespace WpfApp2.Views
{
   
    public partial class AuditoryRowVaiew : UserControl
    {
        public Auditory AudCell0
        {
            get { return (Auditory)GetValue(AudCell0Property); }
            set { SetValue(AudCell0Property, value); }
        }

        public static readonly DependencyProperty AudCell0Property =
           DependencyProperty.Register("AudCell0", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));


        public Auditory AudCell1
        {
            get { return (Auditory)GetValue(AudCell1Property); }
            set { SetValue(AudCell1Property, value); }
        }

         public static readonly DependencyProperty AudCell1Property =
            DependencyProperty.Register("AudCell1", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));

        public Auditory AudCell2
        {
            get { return (Auditory)GetValue(AudCell2Property); }
            set { SetValue(AudCell2Property, value); }
        }

        public static readonly DependencyProperty AudCell2Property =
           DependencyProperty.Register("AudCell2", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));

        public Auditory AudCell3
        {
            get { return (Auditory)GetValue(AudCell3Property); }
            set { SetValue(AudCell3Property, value); }
        }

        public static readonly DependencyProperty AudCell3Property =
           DependencyProperty.Register("AudCell3", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));

        public Auditory AudCell4
        {
            get { return (Auditory)GetValue(AudCell4Property); }
            set { SetValue(AudCell4Property, value); }
        }

        public static readonly DependencyProperty AudCell4Property =
           DependencyProperty.Register("AudCell4", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));

        public Auditory AudCell5
        {
            get { return (Auditory)GetValue(AudCell5Property); }
            set { SetValue(AudCell5Property, value); }
        }

        public static readonly DependencyProperty AudCell5Property =
           DependencyProperty.Register("AudCell5", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));

        public Auditory AudCell6
        {
            get { return (Auditory)GetValue(AudCell6Property); }
            set { SetValue(AudCell6Property, value); }
        }

        public static readonly DependencyProperty AudCell6Property =
           DependencyProperty.Register("AudCell6", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));

        public Auditory AudCell7
        {
            get { return (Auditory)GetValue(AudCell7Property); }
            set { SetValue(AudCell7Property, value); }
        }

        public static readonly DependencyProperty AudCell7Property =
           DependencyProperty.Register("AudCell7", typeof(Auditory), typeof(AuditoryRowVaiew), new PropertyMetadata(null));


        public AuditoryRowVaiew()
        {
            InitializeComponent();
        }
    }
}
