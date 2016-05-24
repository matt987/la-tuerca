using LaTuerca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaTuerca.ViewModels
{
    public class InvoiceViewModel
    {
          public Invoice Invoice { get; set; }
          public List<InvoiceDetail> Details { get; set; }

          public InvoiceViewModel(Invoice _invoice, List<InvoiceDetail> _details)
          {
            Invoice = _invoice;
            Details = _details;
          }
    }
}