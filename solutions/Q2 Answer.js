function nextLowerKey(map, key) {
  let biggest = 0;
  let i;
  for (i in map) {
    i = parseInt(i);
    if (key >= i)
      biggest = map[i];
    else
      break;
  }
  return biggest;
}

module.exports = function Q2(trader, risk, bonus) {
  let a;
  let unRisks = bonus.reduce((obj, v, i) => {
    a = risk[i];
    obj[a] = (obj[a] > v) ? obj[a] : v;
    return obj;
  }, {});
  
  let r;
  let max = 0;
  for (r in unRisks) (unRisks[r] < max) ? delete unRisks[r] : max = unRisks[r];

  return trader.reduce((profit, v) => profit + nextLowerKey(unRisks, v), 0) / 2;
}