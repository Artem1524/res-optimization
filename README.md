# res-optimization
Работа Профилирование и оптимизация ресурсов

Исправлено:

1) Заменил GetComponent при каждом вызове Update и FixedUpdate на вызов кешированных компонентов.
2) Удалил цикл for в файле GameManager.
3) Удалил переменную GameManager. _levelsLength.
