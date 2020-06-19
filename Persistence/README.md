# Persistence
Swappable persistence layer that will handle all direct interactions with a data base.  This layer will 
generally utilize Entity Framework to manage data contexts.  This layer has a dependency
on the Domain layer to define what data looks like.