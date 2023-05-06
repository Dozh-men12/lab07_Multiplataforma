using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_Hurtado.Service
{
    public interface ScaningService
    {
        Task<String> ScanAsync();
    }
}
