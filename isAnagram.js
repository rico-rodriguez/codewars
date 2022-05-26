function anagrams(word, words) {
  return words.filter((w) => {
    return w.split('').sort().join('') === word.split('').sort().join('');
  });
}
