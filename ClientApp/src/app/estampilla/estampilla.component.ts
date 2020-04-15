import { Component, OnInit } from '@angular/core';
import { Estampilla } from './models/estampilla';
import { EstampillaService } from '../services/estampilla.service';

@Component({
  selector: 'app-estampilla',
  templateUrl: './estampilla.component.html',
  styleUrls: ['./estampilla.component.css']
})
export class EstampillaComponent implements OnInit {

  estampilla:Estampilla;
  constructor(private estampillaService:EstampillaService) { }

  ngOnInit(): void {
    this.estampilla=new Estampilla();
  }

  add(){
    this.estampillaService.post(this.estampilla).subscribe(es=>{
      if(es!=null){
        alert("estampilla");
        this.estampilla=es;
      }
    })
  }

}
