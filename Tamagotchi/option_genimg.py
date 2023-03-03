from requests import get
import openai
from time import sleep
from os import system
from sys import argv, exit
from shutil import copyfileobj
from json import load
try:
    with open("config.json") as json_config:
        config_data = load(json_config)
        json_config.close()
    stats_health_level = config_data["stats"]["health"]
except:
    print("Failed to load config.")
if int(stats_health_level) < 40:
    print("Not enough health! Use the heal option.")
    exit()
config_data["stats"]["health"] = str(int(stats_health_level) - 40)
with open("config.json", "w") as f:
    f.write(str(config_data).replace("'", '"'))
    f.close()
#openai.organization = "ORG"
openai.api_key = "API KEY, and no theres nothing here :3"
openai.Model.list()

print("Tamagotchi is drawing the Image...")
try:
    response = openai.Image.create(
    prompt=argv[1].replace("_", " "),
    n=1,
    size=f"1024x1024"
)
except:
    print("Tamagotchi > I dont want to draw right now! Try again later.")
    exit()

try:
    with open("output.png", 'wb') as f:
        copyfileobj(get(response["data"][0]["url"], stream=True).raw, f)
    print("Tamagotchi > Here is your picture!")
    sleep(2)
    system("output.png")
except:
    print("Tamagotchi > I dont want to draw right now! Try again later.")
