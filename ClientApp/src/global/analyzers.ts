import { Analyzer } from 'src/models/analyzer';

export const analyzers: Analyzer[] = [{
  name: 'Syllable counter',
  serverName: 'syllableCounter',
  description: 'Counts all syllables in text'
}, {
  name: 'Percentage of consonants regarding to vowels',
  serverName: 'consonantsPercent',
  description: 'Divides number of consonants by number of vowels'
}, {
  name: 'Most frequent last letter',
  serverName: 'mostFrequentLastLetter',
  description: 'Counts the most frequent letter that is located in the end of the words'
}, {
  name: 'Percentage of words that has more vowels than consonants',
  serverName: 'wordsWithMoreVowelsPercent',
  description: 'Calculates the percentage of words that has more vowels than consonants'
}
]
