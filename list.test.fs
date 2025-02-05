marker ---marker---

require list.fs

also list.fs

: must-equal <> if abort" " else ." OK " then ;

: run-test
  list:create { list1 }

  list1 1 list:append to list1
  list1 2 list:append to list1
  list1 3 list:append to list1
  list1 4 list:append to list1
  list1 5 list:append to list1
  list1 6 list:append to list1

  ." list:for-each -> "
  [: . space ;] list1 list:for-each ." OK?" cr

  ." list:nth -> "
  list1 2 list:nth 3 must-equal cr

  ." list:reduce -> "
  list1 1 [: * ;] list:reduce 720 must-equal cr

  ." list:length -> "
  list1 list:length 6 must-equal cr

  ." list:map -> "
  list1 [: 2 * ;] list:map { list2 }
  list2 list:length list1 list:length must-equal
  list2 0 list:nth list1 0 list:nth 2 * must-equal
  list2 1 list:nth list1 1 list:nth 2 * must-equal
  list2 2 list:nth list1 2 list:nth 2 * must-equal
  list2 3 list:nth list1 3 list:nth 2 * must-equal cr

  ." list:some -> "
  list1 [: 3 = ;] list:some true must-equal cr
;


run-test

---marker---
