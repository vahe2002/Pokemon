# REST Api

- Clona detta projekt
- Se till master branchen är utcheckad
- Öppna upp projektet i [Visual studio](https://www.visualstudio.com/), [VS code](https://code.visualstudio.com/) eller [rider](https://www.jetbrains.com/rider/) eller någon annan editor.
- Starta projektet genom din IDE  eller genom komandotolken:

```bash
$ cd TodoApi/
$ dotnet restore  #laddar ner alla nuget-paket för projektet
$ dotnet run
```

Så där, nu har du ett C# web api körandes på din dator :tada: Låt oss nu testa det
- Se till att du har [Insomnia](https://insomnia.rest/) eller [Postman](https://www.getpostman.com/) 
installerat på din dator eller om du vill använda [curl](https://curl.haxx.se/) så är det också helt okej.
- (om du får problem med "https-cert" (SSL)) Stäng av SSL Certificate verification:
   - Postman: (Postman -> Preferences -> Settings , General -> SSL certificate verification )
   - Insomnia: (Insomnia -> Preferences -> General -> Validate SSL Certificates  )
- Börja med att hämta alla todos genom att göra ett GET anrop mot `https://localhost:5001/api/todo`.
OBS! portnummret (5001) kan vara annorlunda för vissa. Använd då det nummer du får när du startar istället. Eller ställ in på projektet i Visual Studio
.Om allt fungerar som det ska så kommer du få tillbaka följande data:

```json
[
  {
    "id": 1,
    "name": "Buy milk",
    "isComplete": false
  },
  {
    "id": 2,
    "name": "Buy a cat!",
    "isComplete": false
  }
]
```
- Gör nu ett POST anrop mot samma url: `https://localhost:5001/api/todo` för att skapa en ny post och inkludera följande data i HTTP bodyn samt specifiera att det är JSON (application/json):

```json
{
  "name": "walk corcodille",
  "isComplete": false
}
```
Notera att vi inte skickar med ett id men att den får ett unikt autoinkrementerat id.

- Hämta nu ut din nyskapade todo genom att göra ett GET anrop med det specifierade id:t. Om du tappar bort id:t kan du alltid hämta alla todos igen.
- Du ser nu att det är ett stavfel :scream: så du bestämmer dig att uppdatera posten med en PUT (om du rätta till stavfelet innan du posta förut så kan du testa att uppdatera texten till något annat):

```json
{
    "id": 3,
    "name": "walk crocodile",
    "isComplete": false
}
```
- Du kommer på att du inte alls tycker om katter så du försöker ta bort posten om katter genom DELETE genom att göra ett DELETE anrop till 
denna url: `https://localhost:5001/api/todo/2`
Du märker att det inte fungerar och får 404 som response och ser i koden 
till API:et att det inte finns implementerat. Testa nu att göra detta!
Notera att todos kommer återställas vid omstart då de enbart lagras i minnet.

# GraphQL

Följ anvisningarna här: https://bitbucket.valtech.de/bb/projects/TALANG/repos/graph-ql-books/browse

