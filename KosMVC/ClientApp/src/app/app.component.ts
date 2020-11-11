import { Component, OnInit } from '@angular/core';
import { NumberConversionState } from './services/number-conversion-state';
import { NumberConversionService } from './services/number-conversion.service';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  providers: [NumberConversionService]
})
export class AppComponent {
  title = 'app';
  state: NumberConversionState;

  constructor(private numberConversionService: NumberConversionService){}

  ngOnInit(): void{
    this.state = this.numberConversionService.getState();
  }

  convertNumberToWords(src: string){
    this.numberConversionService.convertNumberToWords(src);
  }

  convertNumberToDollars(src: string){
    this.numberConversionService.convertNumberToDollars(src);
  }

}
