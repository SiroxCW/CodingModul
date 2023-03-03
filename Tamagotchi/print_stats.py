from json import load
try:
    with open("config.json") as json_config:
        config_data = load(json_config)
        json_config.close()
    stats_health_level = config_data["stats"]["health"]
except:
    print("Failed to load config.")
if int(stats_health_level) < 30:
    output = "on low life!"
else:
    output = "fine."
print(f"Tamagotchi is {output}\n")
print(f" Health  >>>  {stats_health_level}")