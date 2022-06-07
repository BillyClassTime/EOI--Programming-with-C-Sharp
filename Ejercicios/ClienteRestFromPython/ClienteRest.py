import requests
r=requests.get('https://localhost:7052/WeatherForecast',verify=False)
print('JSON:',r.json())