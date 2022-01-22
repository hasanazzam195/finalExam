import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Patiant } from "src/data/patiant";
@Injectable()
export class PatiantService{
    constructor(private httpCli:HttpClient){}

    Load():Observable<any>{
         return this.httpCli.get("http://localhost/finalProject/api/Patiant/LoadAll")
    }

    LoadCity():Observable<any>{
        return this.httpCli.get("http://localhost/finalProject/api/Patiant/LoadAllCity")
   }

   LoadBed():Observable<any>{
    return this.httpCli.get("http://localhost/finalProject/api/Patiant/LoadAllBed")
   }

   LoadRoom():Observable<any>{
    return this.httpCli.get("http://localhost/finalProject/api/Patiant/LoadAllRoom")
   }

   LoadDoctor():Observable<any>{
    return this.httpCli.get("http://localhost/finalProject/api/Patiant/LoadAllDoctor")
   }

   LoadDepartment():Observable<any>{
    return this.httpCli.get("http://localhost/finalProject/api/Department/LoadAll")
   }

   Insert(pat:Patiant){
       this.httpCli.post("http://localhost/finalProject/api/Patiant/Insert",pat).subscribe();
   }
}