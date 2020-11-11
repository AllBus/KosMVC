import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-number-to-words-from',
  templateUrl: './number-to-words-from.component.html',
  styleUrls: ['./number-to-words-from.component.css']
})
export class NumberToWordsFromComponent implements OnInit {

  inputValue : string = null

  @Input() enable : boolean = false
  @Input() buttonText : string
  @Input() placeholder : string

  @Output() onButtonClick = new EventEmitter<string>()

  constructor() { }

  ngOnInit(): void {
  }

  convertValue(): void {
    this.onButtonClick.emit(this.inputValue)
  }

}
