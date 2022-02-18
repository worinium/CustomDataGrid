using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp
{
    public class MainWindowViewModel : INotifyPropertyChanged
    { 
        private ObservableCollection<WellStatus> wellStatuses;
        public ObservableCollection<WellStatus> WellStatuses
        {
            get { return wellStatuses; }
            set { wellStatuses = value; }
        }
        public MainWindowViewModel()
        {
            wellStatuses = new ObservableCollection<WellStatus>();
            this.GenerateOrders();
        }
        

        private void GenerateOrders()
        {
            wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(2, "OBEN-02", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(3, "OBEN-03", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(4, "OBEN-34", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(5, "OBEN-75", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months", "Abandoned", "Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(6, "OBEN-086", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(7, "OBEN-04", "Chemical Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(8, "OBEN-72", "Enginere Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(9, "OBEN-53", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(10, "OBEN-444", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(11, "OBEN-02", " Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(12, "OBEN-503", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months", "Overdue", "Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(13, "OBEN-034", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(14, "OBEN-02", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(15, "OBEN-13", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(16, "OBEN-04", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(17, "OBEN-502", "Sample", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(18, "OBEN-03", "Iroko", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(19, "OBEN-04", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(20, "OBEN-02", "Enjoyment Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(21, "OBEN-503", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months", "Overdue", "Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(22, "OBEN-44", "Master", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(23, "OBEN-02", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(24, "OBEN-563", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(25, "OBEN-04", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(26, "OBEN-02", "Fien Boy", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(27, "OBEN-443", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months", "Overdue", "Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(28, "OBEN-664", "Soft Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(29, "OBEN-102", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(30, "OBEN-03", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months", "Abandoned", "Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(31, "OBEN-054", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));wellStatuses.Add(new WellStatus(1, "OBEN-01", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Do Nothing","Michael"));
            wellStatuses.Add(new WellStatus(22, "OBEN-02", "Lower Master Valve", "Valve does not close", "Pressure Remains in actuator cylinder", "HH", "02/10/2021","10/02/022","3 months","Active","Review","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(33, "OBEN-803", "Short tubing", "Valve does not close", "Corosion in Tubing", "HH", "02/10/2021","10/02/022","2 months","Active","Do Nothing","Emeka Duruzor"));
            wellStatuses.Add(new WellStatus(34, "OBEN-204", "Lower Master Valve", "Tubing Leak", "Tubing Corosion", "HH", "02/10/2021","10/02/022","4 months","Overdue","Review","Samuel D."));
            
            FilteredList = new ObservableCollection<WellStatus>(wellStatuses);
            collView = CollectionViewSource.GetDefaultView(FilteredList);

            OnPropertyChanged("Search");
        }
        #region Private Fields

        private ICollectionView collView;

        private string search;

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyname)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyname));
        }
        #endregion Private Fields

        #region Public Properties

        public ObservableCollection<WellStatus> Employes { get; set; }
        public ObservableCollection<WellStatus> FilteredList { get; set; }

        /// <summary>
        /// Global filter
        /// </summary>
        public string Search
        {
            get => search;
            set
            {
                search = value;

                collView.Filter = e =>
                {
                    var item = (WellStatus)e;
                    return item != null && ((item.WellName?.StartsWith(search, StringComparison.OrdinalIgnoreCase) ?? false)
                                            || (item.WellAccessories?.StartsWith(search, StringComparison.OrdinalIgnoreCase) ?? false));
                };

                collView.Refresh();

                FilteredList = new ObservableCollection<WellStatus>(collView.OfType<WellStatus>().ToList());

                OnPropertyChanged("Search");
                OnPropertyChanged("FilteredList");
            }
        }

        #endregion Public Properties
    }

}