## ⚠ In case of website beign down, please check my [Instagram](https://instagram.com/haltroy_) or [Discord Server](https://discord.gg/DjZQEvZ8n5). ⚠

<p align="center" style="text-align: center;">
  <img width="128" height="128" src="https://github.com/Haltroy/Yorot/raw/main/Yorot-Avalonia/Assets/Yorot.png" />
</p>

# [Yorot](https://haltroy.com/Yorot.html "Yorot's Page")
A Chromium web browser made by [Haltroy](https://haltroy.com "Haltroy's Website").

Latest Available Version: `None`

### Screenshot(s)
No images are available.

## Features:
 - Built in Apps. 
 - UI language, apps, theme and extension system (supports proxies).
 - Profiles

### Features that I'm aiming to add:
 - HTML5, CSS3, JS, HTML5 Video (except `H.264` and many non-free codecs), WebGL 3D, etc. 
 - Tabbed, built-in search bar that auto-detects URLs.
 - Celebrates your birthday.
 - Developer tools, View Source, Page screen-shot, Print, Keyboard Shortcuts, Save page & Zoom in page
 - Web apps & support for web engines. 
 - Notifications
 - Download manager
 - Custom pages (New Tab, Incognito, Error Page etc.)
 - View local & online webpages

## System Requirements

### Windows
 - .Net Framework 4.6.1 capable computer:
   - Windows 7 SP1 (x86 and x64), Windows 8 (x86 and x64), Windows 8.1 (x86 and x64), Windows 10, Windows Server 2008 R2 SP1 (x64), Windows Server 2012 (x64), Windows Server 2012 R2 (x64) 
   - 1 GHz or faster processor
   - At least 512MB of RAM
   - 2.5 GiB space in drive
 - Internet connection for online content.
 - .Net Framework 4.6.1 & Microsoft Visual C++ 2015
   - Installer will auto-install these requirements if they aren't installed.

### Linux
 - .Net Core 3.1 & Avalonia capable computer:
   - Windows 7 SP1
   - Windows 8.1
   - Windows 10 1607+
   - Windows 11+
   - Nano Server 1803+
   - Windows Server 2012 R2+
   - macOS 10.13+
   - Fedora 32+
   - RHEL 7+
   - CentOS 7+
   - Oracle Linux 7+
   - Debian 9+
   - Ubuntu 16.04+
   - Linux Mint 18+
   - openSUSE 15+
   - SLES 12 SP2+
   - Alpine Linux 3.10+ 
   - Arch Linux and any derivitables (Manjaro, Artix, Garuda etc.)

**+**: That version or newer.

### Android
 - Android 7+


## Links
 - [Discord Server](https://discord.gg/cWJ7cwjTrM)
 - [Haltroy Wiki](https://haltroy.com/wiki)
 - [Haltroy](https://haltroy.com/Yorot)

## Development
The Yorot-Win32 project is developed under .NET Framework, which is only available for Microsoft Windows operating system family.
Yorot-Avalonia and others can be developed under any operating systems. The only requirement is that .NET SDK (in most package managers, `dotnet-sdk`) should be installed to the machine.
If you dualboot your system with 2 completely different operating systems (ex. Windows 11 & any GNU/Linux distribution), please execute the `cleanup.py` Python script before development. This will fix most of the problems with OmniSharp.
 
To develop Yorot, you need:
 - A Git application for downloading code (optional if you used the "Download ZIP" button): GitHub Desktop, git, etc. 
 - Python 3.5 or newer
 - .NET SDK
	- .NET Framework SDK for Yorot-Win32
	- .NET Core 3.1 (or newer versions including the ones that don't have "Core" in its name) SDK for Yorot-Avalonia
 - Microsoft Visual Studio 2019 or newer (for Win32)

Yorot-Win32 packages requires my fork of [`EasyTabs`](https://github.com/Haltroy/EasyTabs.git). Clone the entire repository to `EasyTabs` folder by either using GitHub's "Download ZIP" button, GitHub Desktop or Git.

	git clone https://github.com/Haltroy/EasyTabs.git

###### NOTE: Execute the command above on the Yorot main source folder, not on Yorot-Win32 folder or anywhere else.

 ## Releases & Branches

To see supported versions list, refer to [SECURITY](https://github.com/Haltroy/Yorot/blob/master/SECURITY.md) file.

To see roadmap, refer to [ROADMAP](https://github.com/Haltroy/Yorot/blob/master/ROADMAP.md) file.

 | Branch                                                              | Engine Version | HTAlt  | Status | Release Time |
|----------------------------------------------------------------------|----------------|--------|--------|--------------|
| [`master`](https://github.com/haltroy/Yorot)                         | null           | b1.6.4 | Master | 30 Dec 2020  |
| `0.0.0.1`                                                            | null           | b1.6.4 | Developing | 2021     |

## 3rd-Party Code
Here's a list of third-party coeds used in this project.

| Project | License | Website |
|---------|---------|---------|
| HTAlt | [MIT License]() | [GitHub Repo]() |
| EasyTabs | [BSD License]() | [GitHub Repo]() |
