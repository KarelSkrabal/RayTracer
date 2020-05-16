﻿using System;
using System.Windows.Markup;

namespace RayTracerWPF
{
    public abstract class BaseConverter : MarkupExtension
    {
        public override object ProvideValue(IServiceProvider serviceProvider) => this;
    }
}
