import openai
from sys import argv, exit
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
try:
    #openai.organization = "ORG"
    openai.api_key = "API KEY, and no theres nothing here :3"
    print("Tamagotchi is thinking about the answer...")
    response = openai.Completion.create(model="text-davinci-002", prompt=argv[1], max_tokens=4077)
    print(response["choices"][0]["text"])
except:
    print("Tamagotchi is to tired to think right now...")
