using Android.App;
using ZXing.Mobile;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab07_Hurtado.Droid.Service;
using Xamarin.Forms;
using Lab07_Hurtado.Service;
using System.Threading.Tasks;

[assembly: Dependency(typeof(Class1))]

namespace Lab07_Hurtado.Droid.Service
{
    public class  Class1 :ScaningService
    {
        public async Task<string> ScanAsync()
        {
            MobileBarcodeScanner.Initialize(MainActivity.Instance.Application);

            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }

    }
}