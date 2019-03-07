using C1XfFlexGrid.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace C1XfFlexGrid.Data
{
    public interface IRestService
    {
        Task<List<Customer>> GetCustomersAsync();

    }
}
