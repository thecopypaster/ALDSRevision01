// See https://aka.ms/new-console-template for more information
using _0052.Trie;

// Input keys (use only 'a' 
// through 'z' and lower case)
String[] keys = {"the", "a", "there", "answer",
                        "any", "by", "bye", "their"};

String[] output = { "Not present in trie", "Present in trie" };

Trie trie = new Trie();

// Construct trie
int i;
for (i = 0; i < keys.Length; i++)
    trie.insert(keys[i]);

// Search for different keys
if (trie.search("the") == true)
    Console.WriteLine("the --- " + output[1]);
else Console.WriteLine("the --- " + output[0]);

if (trie.search("these") == true)
    Console.WriteLine("these --- " + output[1]);
else Console.WriteLine("these --- " + output[0]);

if (trie.search("their") == true)
    Console.WriteLine("their --- " + output[1]);
else Console.WriteLine("their --- " + output[0]);

if (trie.search("thaw") == true)
    Console.WriteLine("thaw --- " + output[1]);
else Console.WriteLine("thaw --- " + output[0]);
