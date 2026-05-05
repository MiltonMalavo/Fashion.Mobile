using System;
using System.Collections.ObjectModel;
using Fashion.Mobile.Models;

namespace Fashion.Mobile.Services;

public interface IBaseService<T>
{
    ObservableCollection<T> GetAll();
    T GetById(int Id);
}
