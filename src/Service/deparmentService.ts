import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";

@Injectable()
export class DepartmentService{
    constructor(private httpCli:HttpClient){} 

    Load():Observable<any>{
        return this.httpCli.get("http://localhost/finalProject/api/Department/Load")
    }
}