# Cours de C\# #

### Création de la structure ###

Création de la solution vide :  
`mkdir Isen.Cs && cd Isen.Cs`  
`dotnet new sln`  
Création du projet de type console :  
`mkdir Isen.Cs.ConsoleApp && cd Isen.Cs.ConsoleApp`  
`dotnet new console`  
Création du projet de type librairie (depuis la racine) :  
`mkdir Isen.Cs.Library && cd Isen.Cs.Library`  
`dotnet new classlib`  
Création du projet de type tests unitaires (depuis la racine) :  
`mkdir Isen.Cs.Tests && cd Isen.Cs.Tests`  
`dotnet new xunit`

### Référencement des projets ###

Ajouter au projet console une référence vers le projet Library.
Depuis le dossier du projet console :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  
Ajouter au projet tests une référence vers le projet Library
Depuis le dossier du projet tests :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  
Pour retirer la référence, remplacer `add` par `remove`

### Indiquer au sln la référence des trois projets ###

Depuis la racine de la solution :  
`dotnet sln add Isen.Cs.Library\Isen.Cs.Library.csproj`  
`dotnet sln add Isen.Cs.ConsoleApp\Isen.Cs.ConsoleApp.csproj`  
`dotnet sln add Isen.Cs.Tests\Isen.Cs.Tests.csproj`

### Parenthèse spécifique à Visual Studio (et PAS Visual Studio CODE) ###

On peut créer des "dossier de solution", qui sont des dossiers virtuels (non reflétés dans le filesystem).  
Rangement proposé :

- `src` pour les projets library et console
- `tests` pour les projets de tests
- `sln` pour tous les fichiers hors projet à la racine de la solution

### Ménage ###

Effacer les fichiers .cs générés automatiquement, à l'exception de celui du projet Console.

### Build pour vérifier ###

Il y a 3 étapes, qui s'appelle entre elles, lors d'un build :

- `dotnet restore`  : restaurer les packages "NuGet" distants (mécanisme équivalent à `npm` ).
- `dotnet build` : compiler les projets
- `dotnet run` : exécuter le projet, s'il est exécutable :
  - Executer dans la console, pour un projet console
  - Lancer un serveur web, pour un projet web.

### Initial commit ###

Créer un projet sur Github ou Gitlab.  
Depuis la racine du projet:  
`git init`  
Trouver un .gitignore pour un projet .net Core : https://github.com/dotnet/core/blob/master/.gitignore  
Créer un fichier .gitignore :  
`touch .gitignore`  
Remplir ce fichier avec le contenu exemple.  
`git add .`  
`git commit -m "Initial commit, project structure"`  
`git remote add origin https://github.com/onceuponaban/CS2018.git`  
`git push origin master`  
`git push origin v0.1`

## Ajout d'exercices 'hors projet'  

### A_Types ###
Passage en revue de tous les types primitifs.

Dans le projet Library :

- Créer un dossier Lessons
- Créer ybe ckasse 01_Types (fichier 01_Types.cs)

Inclure toute la structure d'une classe :

- `using` (imports du java)
- `namespace` (package dy java)
- `class`

Coder la classe (voir code)  
L'appeler dans le main()

### B_Enumerations ###

Ce chapitre passe en revue les `enum`.  
Dans le projet Library, créer cette classe.

### C_Arrays ###

Ce chapitre traite des tableaux "primitifs" du style `object[]` ou `object[][]`.  
Créer la classe C_Arrays avec une méthode d'exécution et l'appeler dans le main.