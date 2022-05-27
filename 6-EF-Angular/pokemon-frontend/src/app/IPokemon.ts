import { IAbility } from "./IAbility";

export interface IPokemon{
    id?:number;
    name:string;
    level:number;
    attack:number;
    defense:number;
    health:number;
    abilities?:IAbility[];
}