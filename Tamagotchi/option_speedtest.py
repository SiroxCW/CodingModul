from speedtest import Speedtest
from json import load
try:
    with open("config.json") as json_config:
        config_data = load(json_config)
        json_config.close()
    stats_health_level = config_data["stats"]["health"]
except:
    print("Failed to load config.")
if int(stats_health_level) < 20:
    print("Not enough health! Use the heal option.")
    exit()
config_data["stats"]["health"] = str(int(stats_health_level) - 20)
with open("config.json", "w") as f:
    f.write(str(config_data).replace("'", '"'))
    f.close()
s = Speedtest()
print(f"Download Speed:  {round(s.download() / 1000000)} Mbps")
print(f"Upload Speed:    {round(s.upload() / 1000000)} Mbps")