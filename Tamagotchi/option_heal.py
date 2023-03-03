from json import load
from sys import argv
try:
    with open("config.json") as json_config:
        config_data = load(json_config)
        json_config.close()
    stats_health_level = int(config_data["stats"]["health"])
except:
    print("Failed to load config.")
try:
    stats_health_level += int(argv[1])
    if stats_health_level > 100:
        stats_health_level = 100
    elif stats_health_level < 0:
        stats_health_level = 0
    config_data["stats"]["health"] = str(stats_health_level)
    with open("config.json", "w") as f:
        f.write(str(config_data).replace("'", '"'))
        f.close()
    print(f"New Health Amount: {stats_health_level} HP")
except:
    print("Invalid heal amount!")