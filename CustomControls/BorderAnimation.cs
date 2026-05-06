using System;

namespace Fashion.Mobile.CustomControls;

public class BorderAnimation:Border
{
    public BorderAnimation()
    {
        this.Scale = 0;
        this.Opacity = 0;
        Loaded += (s,e) =>
        {
            this.FadeToAsync(1,1500 ,Easing.CubicInOut);
            this.ScaleToAsync(1, 1500, Easing.CubicInOut);
        };
    }
}
