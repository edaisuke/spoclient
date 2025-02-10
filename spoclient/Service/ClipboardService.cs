﻿using System.Threading.Tasks;
using Avalonia.Controls;

namespace spoclient.Service
{
    public static class ClipboardService
    {
        public static TopLevel? Owner { get; set; }

        public static Task SetTextAsync(string text) =>
            Owner!.Clipboard!.SetTextAsync(text);
    }
}
