import { Component, OnInit, ViewChild } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Bed } from 'src/data/bed';
import { City } from 'src/data/city';
import { Country } from 'src/data/country';
import { Department } from 'src/data/department';
import { Doctor } from 'src/data/doctor';
import { Patiant } from 'src/data/patiant';
import { Room } from 'src/data/room';
import { PatiantService } from 'src/Service/patiant';

@Component({
  selector: 'app-new-patiant',
  templateUrl: './new-patiant.component.html',
  styleUrls: ['./new-patiant.component.css']
})
export class NewPatiantComponent implements OnInit {
  licountry!:Country[]
  liCity!:City[]
  liBed!:Bed[]
  liRoom!:Room[]
  liDoctor!:Doctor[]
  liDeprtment!:Department[]
  @ViewChild('f') forms!:NgForm

  constructor(private PatiantServ:PatiantService) { }

  ngOnInit(): void {
    this.PatiantServ.Load().subscribe(
      data=>{
        this.licountry=data;
      }
    );

    this.PatiantServ.LoadCity().subscribe(
      data=>{
        this.liCity=data;
      }
    );

    this.PatiantServ.LoadBed().subscribe(
      data=>{
        this.liBed=data;
      }
    );

    this.PatiantServ.LoadRoom().subscribe(
      data=>{
        this.liRoom=data
      }
    );

    this.PatiantServ.LoadDoctor().subscribe(
      data=>{
        this.liDoctor=data
      }
    );

    this.PatiantServ.LoadDepartment().subscribe(
      data=>{
        this.liDeprtment=data;
      }
    );
  }

  OnSave(){
    var obj=new Patiant();
    obj.fname=this.forms.value["Fname"]
    obj.fname=this.forms.value["Lname"]
    obj.bdate=this.forms.value["BDate"]
    obj.country_id=parseInt(this.forms.value["ddlCountry"])
    obj.city_id=parseInt(this.forms.value["ddlCity"])
    obj.room_id=parseInt(this.forms.value["ddlRoom"])
    obj.bed_id=parseInt(this.forms.value["ddlBed"])
    obj.doctor_id=parseInt(this.forms.value["ddlDoctor"])
    obj.department_id=parseInt(this.forms.value["ddldept"])

    this.PatiantServ.Insert(obj);
  }

}
