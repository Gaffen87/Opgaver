import requests
import json

def import_roster(num):
    f_id = num
    format_id = "{:0>4}".format(f_id)

    response = requests.get(f"https://www45.myfantasyleague.com/2023/export?TYPE=rosters&L=72358&APIKEY=&FRANCHISE={format_id}&W=&JSON=1")

    players = response.json()["rosters"]["franchise"]["player"]

    playerIDs = list()

    for i in players:
        playerIDs.append(i["id"])
        #print(i["id"])

    idstring = "%2C".join(str(num) for num in playerIDs)
    #print(idstring)

    response = requests.get(f"https://api.myfantasyleague.com/2023/export?TYPE=playerProfile&P={idstring}&JSON=1")
    playerprofiles = response.json()["playerProfiles"]["playerProfile"]

    playernames = list()

    for i in playerprofiles:
        playernames.append(i["name"])

    #for item in playernames:
    #    print(item)

    response = requests.get("https://www45.myfantasyleague.com/2023/export?TYPE=league&L=72358&APIKEY=&JSON=1")
    print(response.json()["league"]["franchises"]["franchise"][num-1]["name"])
    print()
    
    print("Quarterbacks:")
    for item in playernames:
        if "QB" in item:
            print(item)

    print("\nRunning Backs:")
    for item in playernames:
        if "RB" in item:
            print(item)

    print("\nWide Recievers:")
    for item in playernames:
        if "WR" in item:
            print(item)

    print("\nTight Ends:")
    for item in playernames:
        if "TE" in item:
            print(item)

response = request

team_num = int(input("Hvilket hold vil du se?\n1. Ae Fiya Spittarz\n2. 2legit2quit\n3. Chukwuemeka\n4. Dynasty Warriors\n5. Jarlsburgh Steelers\n6. Koch's G-Men\n7. Bruce Wayners\n8. The Real McCoys\n9. Soulrapers\n10. C-Bo's flyttefirma\n"))
print("Henter hold!\n")
import_roster(team_num)
