using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Control de usuario está documentada en https://go.microsoft.com/fwlink/?LinkId=234236

namespace Adaptabilidad_interfaz
{
    public sealed partial class ucRating : UserControl
    {
        public ucRating()
        {
            this.InitializeComponent();
            Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBoundsChanged += UcRatingText_VisibleBoundsChanged;
                ;
        }

        private void UcRatingText_VisibleBoundsChanged (Windows.UI.ViewManagement.ApplicationView sender, object args)
        {
            var Width =Windows.UI.ViewManagement.ApplicationView.GetForCurrentView().VisibleBounds.Width;
            if (Width >= 360)
            {
                RelativePanel.SetBelow(tbTexto, null);
                RelativePanel.SetRightOf(tbTexto, rcStars);
                RelativePanel.SetAlignVerticalCenterWith(tbTexto, rcStars);
                RelativePanel.SetAlignVerticalCenterWithPanel(rcStars, true);
            }
            else
            {
                RelativePanel.SetRightOf(tbTexto, null);
                RelativePanel.SetBelow(tbTexto, rcStars);
                RelativePanel.SetAlignVerticalCenterWith(tbTexto, null);
                RelativePanel.SetAlignVerticalCenterWithPanel(rcStars, false);
            }
        }
    }
}
