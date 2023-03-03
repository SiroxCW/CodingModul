from sys import argv, exit
from socket import error, inet_aton, AF_INET, SOCK_STREAM, socket
from json import load
try:
    with open("config.json") as json_config:
        config_data = load(json_config)
        json_config.close()
    stats_health_level = config_data["stats"]["health"]
except:
    print("Failed to load config.")
if int(stats_health_level) < 10:
    print("Not enough health! Use the heal option.")
    exit()
config_data["stats"]["health"] = str(int(stats_health_level) - 10)
with open("config.json", "w") as f:
    f.write(str(config_data).replace("'", '"'))
    f.close()
ip = argv[1]
port = argv[2]

try:
    inet_aton(ip)
except error:
    print("Invalid IP Adress!")
    exit()
sock = socket(AF_INET, SOCK_STREAM)
result = sock.connect_ex((str(ip), int(port)))
if result == 0:
    print(f"Port {port} is OPEN on {ip}!")
else:
    print(f"Port {port} is closed on {ip}!")