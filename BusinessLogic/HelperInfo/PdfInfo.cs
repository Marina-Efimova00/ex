﻿using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankBussinessLogic.HelperInfo
{
    class PdfInfo
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public List<AuthorViewModel> Authors { get; set; }
    }
}
