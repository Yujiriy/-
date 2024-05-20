using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp1
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        Phone selectedPhone;
        private string _searchText;
        public ICollectionView PhonesView { get; private set; }

        public string SearchText
        {
            get => _searchText;
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                    PhonesView.Refresh();
                }
            }
        }

        IFileService fileService;
        IDialogService dialogService;

        public ObservableCollection<Phone> Phones { get; set; }

        // команда сохранения файла
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.SaveFileDialog() == true)
                          {
                              fileService.Save(dialogService.FilePath, Phones.ToList());
                              dialogService.ShowMessage("Файл сохранен");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        // команда открытия файла
        private RelayCommand openCommand;
        public RelayCommand OpenCommand
        {
            get
            {
                return openCommand ??
                  (openCommand = new RelayCommand(obj =>
                  {
                      try
                      {
                          if (dialogService.OpenFileDialog() == true)
                          {
                              var phones = fileService.Open(dialogService.FilePath);
                              Phones.Clear();
                              foreach (var p in phones)
                                  Phones.Add(p);
                              dialogService.ShowMessage("Файл открыт");
                          }
                      }
                      catch (Exception ex)
                      {
                          dialogService.ShowMessage(ex.Message);
                      }
                  }));
            }
        }

        // команда добавления нового объекта
        private RelayCommand addCommand;
        public RelayCommand AddCommand
        {
            get
            {
                return addCommand ??
                  (addCommand = new RelayCommand(obj =>
                  {
                      Phone phone = new Phone();
                      Phones.Insert(0, phone);
                      SelectedPhone = phone;
                  }));
            }
        }

        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Phone phone = obj as Phone;
                      if (phone != null)
                      {
                          Phones.Remove(phone);
                      }
                  },
                 (obj) => Phones.Count > 0));
            }
        }
        private RelayCommand doubleCommand;
        public RelayCommand DoubleCommand
        {
            get
            {
                return doubleCommand ??
                  (doubleCommand = new RelayCommand(obj =>
                  {
                      Phone phone = obj as Phone;
                      if (phone != null)
                      {
                          Phone phoneCopy = new Phone
                          {
                              Company = phone.Company,
                              Price = phone.Price,
                              Title = phone.Title
                          };
                          Phones.Insert(0, phoneCopy);
                      }
                  }));
            }
        }

        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ApplicationViewModel(IDialogService dialogService, IFileService fileService)
        {
            this.dialogService = dialogService;
            this.fileService = fileService;

            // данные по умлолчанию
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Title="Бобрикович Алексей Владимирович", Company="Кондитер П17", Price=3 },
                new Phone { Title = "Петрова Анна Сергеевна", Company = "Дизайнер", Price = 2},
                new Phone { Title="Бобрикович Юрий Владимирович", Company="Кондитер П17", Price=3 },
                new Phone { Title = "Петрова Анна Сергеевна", Company = "Дизайнер", Price = 2},

            };
            PhonesView = CollectionViewSource.GetDefaultView(Phones);
            PhonesView.Filter = FilterPhones;
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private bool FilterPhones(object obj)
        {
            if (obj is Phone phone)
            {
                return string.IsNullOrEmpty(SearchText) ||
                       phone.Title.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0 ||
                       phone.Company.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0;
            }
            return false;
        }

    }
}
