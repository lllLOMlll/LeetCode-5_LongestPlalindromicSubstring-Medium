public class Solution {
    public string LongestPalindrome(string s) {
        return "laval";
    }

static void Main(string[] args)
{
    Solution s = new Solution();

    string input1 = "babad";
    Console.WriteLine("bab = " + s.LongestPalindrome(input1));

     string input2 = "cbbd";
    Console.WriteLine("bb = " + s.LongestPalindrome(input2));
}
}



Pour rendre votre solution plus professionnelle et pratiquer les tests unitaires, vous pouvez utiliser un framework de tests unitaires comme **NUnit** ou **xUnit**, largement utilisés en C#. Voici une proposition d'approche :

1. **Supprimez le `Main` pour éviter de mélanger tests et logique de l'application.**
2. **Créez une classe de tests distincte** dans votre projet en utilisant un framework de test.
3. **Écrivez des tests unitaires avec plusieurs scénarios** (cas simples, cas limites, cas spéciaux).

### Exemple avec NUnit

1. **Installer NUnit et NUnit3TestAdapter :**
   - Utilisez NuGet pour ajouter les packages suivants à votre projet :
     - `NUnit`
     - `NUnit3TestAdapter` (nécessaire pour exécuter les tests avec Visual Studio).

2. **Créer une classe de tests :**

```csharp
using NUnit.Framework;

[TestFixture]
public class SolutionTests
{
    [Test]
    public void TestLongestPalindrome_BasicCase()
    {
        // Arrange
        Solution solution = new Solution();
        string input = "babad";
        string expected = "bab"; // ou "aba"

        // Act
        string result = solution.LongestPalindrome(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestLongestPalindrome_EvenLengthCase()
    {
        // Arrange
        Solution solution = new Solution();
        string input = "cbbd";
        string expected = "bb";

        // Act
        string result = solution.LongestPalindrome(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestLongestPalindrome_SingleCharacter()
    {
        // Arrange
        Solution solution = new Solution();
        string input = "a";
        string expected = "a";

        // Act
        string result = solution.LongestPalindrome(input);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void TestLongestPalindrome_EmptyString()
    {
        // Arrange
        Solution solution = new Solution();
        string input = "";
        string expected = "";

        // Act
        string result = solution.LongestPalindrome(input);

        // Assert
        Assert.AreEqual(expected, result);
    }
}
```

3. **Exécuter les tests :**
   - Dans Visual Studio, ouvrez **Test Explorer** (menu Test > Windows > Test Explorer).
   - Exécutez tous les tests pour vérifier si votre implémentation fonctionne comme attendu.

---

### Points importants :
- Utilisez des **assertions** pour valider les résultats attendus.
- Créez des **cas de tests diversifiés** : entrées normales, cas limites, entrées inhabituelles.
- Gardez vos tests indépendants pour éviter les effets de bord.

Cela structure mieux vos tests et suit les bonnes pratiques de développement. Vous pouvez également essayer **xUnit**, qui est très similaire à NUnit.