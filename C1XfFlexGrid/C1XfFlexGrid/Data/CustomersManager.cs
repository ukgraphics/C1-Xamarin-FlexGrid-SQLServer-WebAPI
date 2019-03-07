﻿using C1XfFlexGrid.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace C1XfFlexGrid.Data
{
    public class CustomersManager
    {
        IRestService restService;

        public CustomersManager(IRestService service)
        {
            restService = service;
        }

        public Task<List<Customer>> GetCustomersAsync()
        {
            return restService.GetCustomersAsync();
        }

        //public Task SaveTaskAsync(TodoItem item, bool isNewItem = false)
        //{
        //    return restService.SaveTodoItemAsync(item, isNewItem);
        //}

        //public Task DeleteTaskAsync(TodoItem item)
        //{
        //    return restService.DeleteTodoItemAsync(item.ID);
        //}
    }
}
