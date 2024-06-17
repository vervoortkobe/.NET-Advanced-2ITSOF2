string sentence = "DIT IS EEN ZIN MET 8 WOORDEN EN 2 CIJFERS";

sentence.Where(c => c == 'E')
       .Dump();

sentence.Where(c => c == 'E' || c == 'Z')
       .Dump();

sentence.Where(c => c <= 'E' && c != ' ')
       .Dump();

int[] sequence = new int[] { 1, 20, 5, 32, 2, 8, 77, 100 };

sequence.Where(n => n % 5 == 0)
       .Dump();

sequence.Where((n, i) => i % 2 != 0)
       .Dump();

sentence.Where(c => c != ' ')
       .OrderBy(c => c)
       .Dump();

sentence.Where(c => c != ' ')
       .OrderBy(c => c)
       .Distinct()
       .Dump();

sequence.Where(n => n % 5 == 0)
       .OrderByDescending(n => n)
       .Dump();

sentence.Split(' ')
       .Where(w => w.Length >= 3)
       .OrderBy(w => w.First())
       .GroupBy(w => w.Length)
       .OrderBy(g => g.Key)
       .Dump();

sequence.OrderBy(n => n)
       .GroupBy(n => n / 10)
       .Dump();

sequence.OrderBy(n => n)
       .GroupBy(n => n % 10)
       .OrderBy(g => g.Key)
       .Dump();

sentence.Where(c => c != ' ')
       .Count()
       .Dump();

sentence.Split(' ')
       .Where(w => w.Length >= 2)
       .Count()
       .Dump();

sentence.Split(' ')
       .OrderByDescending(w => w.Length)
       .First()
       .Count()
       .Dump();

sentence.Split(' ')
       .OrderBy(w => w.Length)
       .GroupBy(w => w.Length)
       .Select(g => new { Length = g.Key, Count = g.Count() })
       .Dump();

sequence.Where(n => n > 10)
       .Sum()
       .Dump();

sequence.OrderByDescending(n => n)
       .GroupBy(n => n % 2 == 0)
       .Select(g => new { Even = g.Key, Count = g.Count(), Max = g.First(), Avg = g.Average() })
       .Dump();
