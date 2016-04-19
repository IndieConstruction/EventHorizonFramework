Fate così:
- inserite nel progetto questi 3 files
- Create una nuova scena
- un oggetto in scena a cui agganciate spawner.cs
- create poi 2 prefab che abbiano rispettivamente agganciato lo scritp InterfacedGO1 e InterfacedGO2
- a questo punto, prima di far partire la scena, collegate i 2 prefab alla lista di gameobject pubblica dello spawner.
- fate partire e vedrete che ogniuno dei 2 prefab stampa qualcosa di diverso.

la cosa da notare è che lo spawner da l'ordine di far fare qualcosa senza sapere di che tipo sia il componente agganciato al prefab, ma lo tratta semplicemente tramite l'interfaccia... la maggia dell'interfaccia che tanto affascina Amir!!! :)
