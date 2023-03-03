from os import system
from json import load
try:
    with open("config.json") as json_config:
        config_data = load(json_config)
        json_config.close()
    stats_health_level = config_data["stats"]["health"]
except:
    print("Failed to load config.")
if int(stats_health_level) < 30:
    print("Not enough health! Use the heal option.")
    exit()
config_data["stats"]["health"] = str(int(stats_health_level) - 30)
with open("config.json", "w") as f:
    f.write(str(config_data).replace("'", '"'))
    f.close()
system("z.exe")