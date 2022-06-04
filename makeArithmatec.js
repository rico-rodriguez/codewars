function arithmetic(a, b, operator) {
  return operator === 'add'
    ? a + b
    : operator === 'subtract'
    ? a - b
    : operator === 'multiply'
    ? a * b
    : a / b;
}
