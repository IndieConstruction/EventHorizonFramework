La classe SpawnerRandom riempie una lista di gameobject templates "scansionando" la cartella resources e controlla prima di aggiungerle alla lista che abbiamo un component che implementa l'interfaccia corretta, altrimenti semplicemente non lo considera template valido e non lo aggiunge.
Poi, alla pressione di "S" esegue lo spawn random da tutti gli alementi della lista e richiama pure la funzione prevista dall'interfaccia, cos�, a sfreggggio!

Enjoy
Brago

P.S.
Tutto � sotto apposito namespace dedicato al learning, cos� non da fastidio al resto.