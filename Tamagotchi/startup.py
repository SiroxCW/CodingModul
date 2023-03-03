from ctypes import windll
from os import system, listdir
from os.path import isfile
from sys import exit
from pystyle import Anime, Center, Colors, Colorate, System
windll.kernel32.SetConsoleTitleW(f"Tamagotchi - Starting Up... - Successfully imported Libraries")
banner = r"""
Starting Up!

  .^._.^.
  | @ @ |
 (  ---  )
 .'     '.
 |/     \|
  \ /-\ /
   V   V
"""
System.Size(175, 40)
windll.kernel32.SetConsoleTitleW(f"Tamagotchi - Starting Up... - Successfully set Window Size")
Anime.Fade(Center.Center(banner), Colors.red_to_green, Colorate.Vertical, time=1)
for i in listdir():
    if isfile(i) and i.endswith(".exe"):
        windll.kernel32.SetConsoleTitleW(f"Tamagotchi - Starting Up... - Trying to call {i}")
        system(i)
        exit()