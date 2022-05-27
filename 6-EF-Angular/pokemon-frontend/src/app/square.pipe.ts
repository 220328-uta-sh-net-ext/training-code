import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'square'
})
export class SquarePipe implements PipeTransform {

  // In a custom pipe you need to implement this method to specify how the data 
  // is going to be transformed
  transform(value: number): number {
    return value*value;
  }

}
