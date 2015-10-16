# SteamDeploy
A companion program for Steam backup discs.

#### Problem
I make it a habit to use the Backup/Restore feature on Steam to backup my games on discs. With just the barebones backup files though, the disc is pretty basic. When I insert it, I have to go to Steam and navigate the menu, browse the folder, and overall it just felt kind of un-seamless.

#### Solution
That's how I came to the conclusion of making SteamDeploy. What it does is simply provide a one-click solution for my backed up game to be easily restored on Steam.

#### What it does
Coupled with an `autorun.inf` file, it will prompt Steam to restore the game in the disc giving the familiar disc installation process that Windows users have been familiar with. Only this time, it's on Steam.

#### How to use
Just download the latest version from the [Releases page](https://github.com/ShedoSurashu/SteamDeploy/releases) and pop it into the root of the disc. Don't forget to change the `label` inside `autorun.inf` to your game's name and, if applicable, the disc number.

![Disc structure](http://i.imgur.com/m9FK3mq.png)

![Autorun.inf contents](http://i.imgur.com/r3iMAsT.png)

Launching SteamDeploy opens the the Steam install dialogue without having to go through the menu.

![Steam install dialogue opened by SteamDeploy directly from the disc](http://i.imgur.com/6r2r4i0.png)

#### How it works
It checks the registry for the Steam installation and then uses that information to properly instruct Steam to install the game using the disc that SteamDeploy resides in. If you run SteamDeploy on places other than a backup disc, it will just exit immediately. If it doesn't detect the Steam installation, it will prompt to either download Steam or ask for the `Steam.exe`'s path.

![When SteamDeploy fails to detect Steam installation](http://i.imgur.com/TFpEQTk.png)
