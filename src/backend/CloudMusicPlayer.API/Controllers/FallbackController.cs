﻿using Microsoft.AspNetCore.Mvc;

namespace CloudMusicPlayer.API.Controllers;

public sealed class FallbackController : Controller
{
    public IActionResult Index()
    {
        return PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html"), "text/HTML");
    }
}
